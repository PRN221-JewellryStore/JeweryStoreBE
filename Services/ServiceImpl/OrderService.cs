﻿using BusinessObjecs.DTOs;
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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public async Task<List<GetOrderResponse>> Add(OrderDTO OrderDTO, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {
            var userId = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            if (userId is null)
            {
                throw new Exception("User not authorized!");
            }
            var order = OrderDTO.Adapt<OrderEntity>();

            order.UserID = userId;
            order.Status = "InCart";
            order.PrimaryPrice = 0;
            order.Total = 0;
            order.CreatorID = userId;

            _OrderRepository.Add(order);
            if (await _OrderRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return (await _OrderRepository.GetAllWithDetail(cancellationToken))
                    .Where(o => o.UserID == userId).Adapt<List<GetOrderResponse>>();
            }
            throw new Exception("Something went wrong! Add action unsuccesful");
        }

        public async Task<OrderDTO> Delete(string id, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {
            var Order = await _OrderRepository.FindAsync(p => p.ID.Equals(id));
            if (Order is null)
            {
                throw new NotFoundException("Order not existed!");
            }

            Order.DeleterID = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            Order.DeletedAt = DateTime.Now;

            if (await _OrderRepository.UnitOfWork.SaveChangesAsync(cancellationToken) != 0)
            {
                return Order.Adapt<OrderDTO>();
            }
            throw new Exception("Something went wrong! Delete action unsuccesful");
        }

        public async Task<List<GetOrderResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _OrderRepository.GetAllWithDetail(cancellationToken);
            return result.Adapt<List<GetOrderResponse>>();
        }

        public async Task<GetOrderResponse> GetById(string id, CancellationToken cancellationToken)
        {
            var result = (await _OrderRepository.GetAllWithDetail(cancellationToken)).FirstOrDefault(p => p.ID.Equals(id));
            if (result is null)
            {
                throw new NotFoundException("Order not existed");
            }
            return result.Adapt<GetOrderResponse>();
        }

        public async Task<OrderDTO> Update(string id, OrderDTO OrderDTO, CancellationToken cancellationToken, ClaimsPrincipal claims)
        {
            var userId = claims.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
            if (userId is null)
            {
                throw new Exception("User not authorized!");
            }

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
                Order.UserID = userId;
                Order.UpdaterID = userId;
                Order.LastestUpdateAt = DateTime.UtcNow;
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
        public async Task<List<GetOrderResponse>> GetByUserId(string userId, CancellationToken cancellationToken)
        {
            var result = (await _OrderRepository.GetAllWithDetail(cancellationToken)).Where(p => p.UserID.Equals(userId)).ToList();
            if (result is null)
            {
                throw new NotFoundException("Order not existed");
            }
            return result.Adapt<List<GetOrderResponse>>();
        }
    }
}
