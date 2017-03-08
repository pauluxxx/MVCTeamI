using MVCTeamProducts.DTO;
using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Business.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IList<ProductDto> products = new List<ProductDto>{
            new ProductDto{Id=1,Name="Кепка",Price=22.3m},
            new ProductDto{Id=2,Name="Тапочки",Price=17.7m},
            new ProductDto{Id=3,Name="Толстовка",Price=36.2m}
        };
        //premium is extend products
        private IList<ProductDto> premiumProducts = new List<ProductDto>{
            new ProductDto{Id=4,Name="Цепочка серебро",Price=222.3m},
            new ProductDto{Id=5,Name="Кальян",Price=357.7m},
            new ProductDto{Id=6,Name="Сережки",Price=736.2m}
        };
        public IEnumerable<Product> GetProducts() {
            return products.Select(p => new Product(p, AccountType.Basic)).ToList();
        }
        public IEnumerable<Product> GetPremiumProducts()
        {
            return premiumProducts.Select(p => new Product(p, AccountType.Premium)).ToList();
        }
    }
}