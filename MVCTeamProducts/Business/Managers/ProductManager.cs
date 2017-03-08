using MVCTeamProducts.Business.Repositories;
using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Business.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IAccountRepository accountsRepository;
        private readonly IProductRepository productsRepository;
        public ProductManager(IAccountRepository accountsRepository, IProductRepository productsRepository)
        {
            this.accountsRepository = accountsRepository;
            this.productsRepository = productsRepository;
        }
        public IEnumerable<Product> GetProductsByType(int userId){
            var account = accountsRepository.GetById(userId);
            if (account==null)
            {
                return null;
            }
            var products = new List<Product>();
            var basicProducts = productsRepository.GetProducts();
            if (basicProducts!=null)
            {
                products.AddRange(basicProducts);
            }
            if (account.AccountType==AccountType.Premium)
            {
                var premiumProducts = productsRepository.GetPremiumProducts();
                if (premiumProducts!=null)
                {
                    products.AddRange(premiumProducts);
                }
            }
            return products;
        }
    } 
}