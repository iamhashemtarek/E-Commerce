﻿using ECommerce.Core.Entities;

namespace ECommerce.APIs.DTOs
{
    public class ProductToReturnDto
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public int ProductCategoryId { get; set; }
        public string Category { get; set; }
        public int ProductBrandId { get; set; }
        public string Brand { get; set; }
    }
}
