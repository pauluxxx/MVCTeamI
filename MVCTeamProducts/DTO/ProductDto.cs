using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.DTO
{
    public class ProductDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}