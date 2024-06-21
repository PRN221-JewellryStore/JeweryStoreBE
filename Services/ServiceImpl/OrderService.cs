using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using Mapster;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public async Task<OrderDTO> Add(OrderDTO OrderDTO, CancellationToken cancellationToken)
        {
            _OrderRepository.Add(OrderDTO.Adapt<OrderEntity>());
            if (await _OrderRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return OrderDTO;
            }
            throw new Exception("Something went wrong! Add action unsuccesful");
        }

        public async Task<OrderDTO> Delete(string id, CancellationToken cancellationToken)
        {
            var Order = await _OrderRepository.FindAsync(p => p.ID.Equals(id));
            if (Order is null)
            {
                throw new NotFoundException("Order not existed!");
            }

            _OrderRepository.Remove(Order);

            if (await _OrderRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return Order.Adapt<OrderDTO>();
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }

        public async Task<List<OrderEntity>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _OrderRepository.FindAllAsync(cancellationToken);
            return result;
        }

        public async Task<OrderEntity> GetById(string id, CancellationToken cancellationToken)
        {
            var result = await _OrderRepository.FindAsync(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("Order not existed");
            }
            return result;
        }

        public async Task<OrderDTO> Update(string id, OrderDTO OrderDTO, CancellationToken cancellationToken)
        {
            var Order = await _OrderRepository.FindAsync(p => p.ID.Equals(id));
            if (Order is null)
            {
                throw new NotFoundException("Order not found!");
            }
            try
            {
                Order.Note = OrderDTO.Note;
                Order.PromotionID = OrderDTO.PromotionID;
                Order.CounterID = OrderDTO.CounterID;
                Order.UserID = OrderDTO.UserID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (await _OrderRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return OrderDTO;
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }
    }
}
