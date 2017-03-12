using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTeamProducts.Models.Domain;

namespace MVCTeamProducts.Business.Repositories
{
    public class MySqlProductsRepository : IProductRepository
    {
        private ProductsContext prductContext;
        public MySqlProductsRepository()
        {
            prductContext = new ProductsContext();
        }
        public IEnumerable<Product> GetPremiumProducts()
        {
            return prductContext.Prodcuts.Where(p => p.isPremium).ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return prductContext.Prodcuts.Where(p => !p.isPremium).ToList();
        }
    }
}