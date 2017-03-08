using MVCTeamProducts.Models.Domain;
using MVCTeamProducts.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTeamProducts.Business.VmBuilders
{
    public interface IProductVmBuilder
    {
        ProductVm GetVm(Product prod);
        ProductListVm GetVmList(IEnumerable<Product> products);
    }
}
