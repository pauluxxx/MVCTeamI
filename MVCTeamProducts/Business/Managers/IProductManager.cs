using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCTeamProducts.Business.Managers
{
    public interface IProductManager
    {
        IEnumerable<Product> GetProductsByType(int userId);
    }
}
