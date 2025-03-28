﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Core.Entities.Order_Aggregate;

namespace ECommerce.Core.Services.Contracts
{
    public interface IOrderService
    {
        Task<Order?> CreateOrderAsync(string buyerEmail, string basketId, int deliveryMethodId, Address shippingAddress);
        Task<IReadOnlyList<Order>> GerOrdersForUserAsync(string buyerEmail);
        Task<Order> GetOrderByIdForUserAsync(int orderId, string buyerEmail);
        public Task<IReadOnlyList<DeliveryMethod>> GetDeliveryMethodsAsync();
    }
}
