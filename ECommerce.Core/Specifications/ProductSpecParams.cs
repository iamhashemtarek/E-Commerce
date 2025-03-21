﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 10;
        private int? pageSize = 5;
        public string? Sort { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public int? PageIndex { get; set; } = 1;

        public int? PageSize
        {
            get => pageSize;
            set => pageSize = value > MaxPageSize ? MaxPageSize : value;
        }
    }
}
