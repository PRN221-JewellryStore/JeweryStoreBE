using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.ResponseModels;
using Mapster;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _OrderDetailRepository;
        private readonly IOrderRepository _OrderRepository;
        private readonly IPromotionRepository _PromotionRepository;
        private readonly IProductRepository _ProductRepository;
        private readonly ICategoryRepository _CategoryRepository;
        private readonly IOrderService _OrderService;


        public OrderDetailService(IOrderDetailRepository OrderDetailRepository, IOrderRepository orderRepository, IPromotionRepository promotionRepository, IProductRepository productRepository, ICategoryRepository categoryRepository, IOrderService orderService)
        {
            _OrderDetailRepository = OrderDetailRepository;
            _OrderRepository = orderRepository;
            _PromotionRepository = promotionRepository;
            _ProductRepository = productRepository;
            _CategoryRepository = categoryRepository;
            _OrderService = orderService;
        }

        public async Task<GetOrderResponse> Add(OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {
            var userId = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            if (userId is null)
            {
                throw new Exception("User not authorized!");
            }
            var order = await _OrderRepository.FindAsync(o => o.ID == OrderDetailDTO.OrderID);
            if (order is null)
            {
                throw new NotFoundException("Order not existed!");
            }
            /*
            if (order.Status != "InCart")
            {
                throw new Exception("Status is not InCart");
            }
            */
            var promotion = await _PromotionRepository.FindAsync(p => p.ID == order.PromotionID);

            var product = await _ProductRepository.FindAsync(p => p.ID == OrderDetailDTO.ProductID);
            if (product is null)
            {
                throw new NotFoundException("Product not found!");
            }
            if (product.Quantity < OrderDetailDTO.Quantity)
            {
                throw new Exception("Not enough product in storage");
            }
            var category = await _CategoryRepository.FindAsync(c => c.ID == product.CategoryID);

            try
            {
                var orderDetail = OrderDetailDTO.Adapt<OrderDetailEntity>();

                var primaryPrice = OrderDetailDTO.Quantity * product.Cost;
                if (promotion != null)
                {
                    var reducedPrice = (decimal)(promotion.ReducedPercent) * primaryPrice / 100;
                    var discountPrice = (reducedPrice > promotion.MaximumReduce)
                            ? primaryPrice - promotion.MaximumReduce
                            : primaryPrice - reducedPrice;
                    order.Total += discountPrice;
                }
                else
                {
                    order.Total += primaryPrice;
                }
                orderDetail.ProductCost = primaryPrice;
                orderDetail.CreatorID = userId;

                _OrderDetailRepository.Add(orderDetail);

                order.Status = "Done";
                order.PrimaryPrice += primaryPrice;
                product.Quantity -= orderDetail.Quantity;
                await _OrderDetailRepository.UnitOfWork.SaveChangesAsync();
                return (await _OrderService.GetById(orderDetail.OrderID, cancellationToken)).Adapt<GetOrderResponse>();
            }
            catch (Exception ex)
            {
                order.Status = "Cancelled";
                order.PrimaryPrice = 0;
                order.Total = 0;
                await _OrderDetailRepository.UnitOfWork.SaveChangesAsync();
                throw new Exception("Something went wrong! Add action unsuccesful");
            }
        }

        public async Task<OrderDetailDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {
            var OrderDetail = await _OrderDetailRepository.FindAsync(p => p.ID.Equals(id));
            if (OrderDetail is null)
            {
                throw new NotFoundException("OrderDetail not existed!");
            }

            OrderDetail.DeleterID = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            OrderDetail.DeletedAt = DateTime.Now;

            if (await _OrderDetailRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return OrderDetail.Adapt<OrderDetailDTO>();
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }

        public async Task<List<GetOrderDetailResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _OrderDetailRepository.GetAllWithDetail(cancellationToken);
            return result.Adapt<List<GetOrderDetailResponse>>();
        }

        public async Task<GetOrderDetailResponse> GetById(string id, CancellationToken cancellationToken)
        {
            var result = (await _OrderDetailRepository.GetAllWithDetail(cancellationToken)).FirstOrDefault(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("OrderDetail not existed");
            }
            return result.Adapt<GetOrderDetailResponse>();
        }

        public async Task<OrderDetailDTO> Update(string id, OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken)
        {
            var OrderDetail = await _OrderDetailRepository.FindAsync(p => p.ID.Equals(id));
            if (OrderDetail is null)
            {
                throw new NotFoundException("OrderDetail not found!");
            }
            try
            {
                OrderDetail.OrderID = OrderDetailDTO.OrderID;
                OrderDetail.ProductID = OrderDetailDTO.ProductID;
                OrderDetail.Quantity = OrderDetailDTO.Quantity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (await _OrderDetailRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return OrderDetailDTO;
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }
    }
}
