﻿using MVCTeamProducts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Models.Domain
{
    public class Product
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool isPremium { get; set; }
        public Product(ProductDto dto,AccountType accountType) {
            this.Id = dto.Id;
            this.Name = dto.Name;
            this.Price = dto.Price;
            this.isPremium = accountType == AccountType.Premium;
        }
    }
}