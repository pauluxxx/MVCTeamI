using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTeamProducts.Business.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetPremiumProducts();

       
    }
}
