using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
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

        public OrderDetailService(IOrderDetailRepository OrderDetailRepository, IOrderRepository orderRepository, IPromotionRepository promotionRepository, IProductRepository productRepository)
        {
            _OrderDetailRepository = OrderDetailRepository;
            _OrderRepository = orderRepository;
            _PromotionRepository = promotionRepository;
            _ProductRepository = productRepository;
        }

        public async Task<OrderDetailDTO> Add(OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken)
        {
            var order = await _OrderRepository.FindAsync(o => o.ID == OrderDetailDTO.OrderID);
            if (order is null)
            {
                throw new NotFoundException("Order not existed!");
            }

            var promotion = await _PromotionRepository.FindAsync(p => p.ID == order.PromotionID);
            if (promotion is null)
            {
                throw new NotFoundException("Promotion not found!");
            }

            var product = await _ProductRepository.FindAsync(p => p.ID == OrderDetailDTO.ProductID);
            if (product is null)
            {
                throw new NotFoundException("Promotion not found!");
            }

            var orderDetail = OrderDetailDTO.Adapt<OrderDetailEntity>();
            var reducedPrice = (decimal) (OrderDetailDTO.Quantity * promotion.ReducedPercent) * product.Cost / 100;

            orderDetail.ProductCost = (reducedPrice > promotion.MaximumReduce) 
                ? OrderDetailDTO.Quantity * product.Cost - promotion.MaximumReduce
                : OrderDetailDTO.Quantity * product.Cost - reducedPrice;

            _OrderDetailRepository.Add(orderDetail);

            order.Status = "Done";
            order.Total += orderDetail.ProductCost;

            if (await _OrderDetailRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return OrderDetailDTO;
            }
            throw new Exception("Something went wrong! Add action unsuccesful");
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

        public async Task<List<OrderDetailEntity>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _OrderDetailRepository.GetAllWithDetail(cancellationToken);
            return result;
        }

        public async Task<OrderDetailEntity> GetById(string id, CancellationToken cancellationToken)
        {
            var result = (await _OrderDetailRepository.GetAllWithDetail(cancellationToken)).FirstOrDefault(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("OrderDetail not existed");
            }
            return result;
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
