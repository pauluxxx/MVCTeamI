using MVCTeamProducts.Models.Domain;
using MVCTeamProducts.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Business.VmBuilders
{
    public class ProductVmBuilder:IProductVmBuilder
    {
        public ProductVm GetVm(Product prod) {
            return new ProductVm { Product = prod };
        }
        public ProductListVm GetVmList(IEnumerable<Product> products) {
            return new ProductListVm { Products = products.Select(GetVm).ToList() };
        }

    }
}