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
        private readonly ICounterRepository _CounterRepository;
        private readonly ICategoryRepository _CategoryRepository;

        public OrderDetailService(IOrderDetailRepository OrderDetailRepository, IOrderRepository orderRepository, IPromotionRepository promotionRepository, IProductRepository productRepository, ICounterRepository counterRepository, ICategoryRepository categoryRepository)
        {
            _OrderDetailRepository = OrderDetailRepository;
            _OrderRepository = orderRepository;
            _PromotionRepository = promotionRepository;
            _ProductRepository = productRepository;
            _CounterRepository = counterRepository;
            _CategoryRepository = categoryRepository;
        }

        public async Task<GetOrderResponse> Add(OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken)
        {
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
            var counter = await _CounterRepository.FindAsync(c => c.ID == order.CounterID);
            var category = await _CategoryRepository.FindAsync(c => c.ID == product.CategoryID);
            if ( counter != null && category != null && !counter.Name.Contains(category.Name))
            {
                throw new Exception("Product's category is not match with counter.");
            }

            try
            {
                var orderDetail = OrderDetailDTO.Adapt<OrderDetailEntity>();

                var primaryPrice = OrderDetailDTO.Quantity * product.Cost;

                if (promotion is null)
                {
                    orderDetail.ProductCost = OrderDetailDTO.Quantity * product.Cost;
                }
                else
                {
                    var reducedPrice = (decimal)(promotion.ReducedPercent) * primaryPrice / 100;

                    orderDetail.ProductCost = (reducedPrice > promotion.MaximumReduce)
                        ? primaryPrice - promotion.MaximumReduce
                        : primaryPrice - reducedPrice;
                }

                _OrderDetailRepository.Add(orderDetail);

                order.Status = "Done";
                order.PrimaryPrice += primaryPrice;
                order.Total += orderDetail.ProductCost;
                product.Quantity -= orderDetail.Quantity;
                await _OrderDetailRepository.UnitOfWork.SaveChangesAsync();
                return order.Adapt<GetOrderResponse>();
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
