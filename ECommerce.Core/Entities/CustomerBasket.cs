﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class CustomerBasket
    {

        public string Id { get; set; }
        public List<BasketItems> Items { get; set; }
        public string PaymentIntentId { get; set; }
        public string ClientSecret { get; set; }
        public int? DeliveryMethodId { get; set; }
        public decimal ShippingPrice { get; set; }
        public CustomerBasket(string id)
        {
            Id = id;
            Items = new List<BasketItems>();
        }
    }
}
