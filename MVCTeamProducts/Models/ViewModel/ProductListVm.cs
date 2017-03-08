using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Models.ViewModel
{
    public class ProductListVm
    {
        public IEnumerable<ProductVm> Products { get; set; }
        
    }
}