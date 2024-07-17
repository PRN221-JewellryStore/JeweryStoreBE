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

        public OrderDetailService(IOrderDetailRepository OrderDetailRepository)
        {
            _OrderDetailRepository = OrderDetailRepository;
        }

        public async Task<OrderDetailDTO> Add(OrderDetailDTO OrderDetailDTO, CancellationToken cancellationToken)
        {
            _OrderDetailRepository.Add(OrderDetailDTO.Adapt<OrderDetailEntity>());
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
                OrderDetail.ProductCost = OrderDetailDTO.ProductCost;
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
