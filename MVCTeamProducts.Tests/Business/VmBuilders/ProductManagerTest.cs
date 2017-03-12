using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCTeamProducts.Business.VmBuilders;
using MVCTeamProducts.DTO;
using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTeamProducts.Business.VmBuilders.Tests
{
    [TestClass()]
    public class ProductManagerTest
    {
        [TestMethod()]
        public void GetVmTest()
        {
            var builder = new ProductVmBuilder();
            var product = new Product(new ProductDto { Id = 1, Name = "A", Price = 12m }, AccountType.Basic);
            var productPrem = new Product(new ProductDto { Id = 2, Name = "B", Price = 12m }, AccountType.Premium);

            var res = builder.GetVm(product);
            var res2 = builder.GetVm(productPrem);
            string labelBasic = AccountType.Basic.ToString();
            string labelPrem = AccountType.Premium.ToString();

            Assert.IsNotNull(res);
            Assert.AreEqual(res.AccountTypeLabel, labelBasic);
            Assert.IsNotNull(res2);
            Assert.AreEqual(res2.AccountTypeLabel, labelPrem);
           

        }

        [TestMethod()]
        public void GetVmListTest()
        {
            var builder = new ProductVmBuilder();
            IEnumerable<Product> basic = new List<ProductDto> { new ProductDto { Id = 1, Name = "A", Price = 10m }, new ProductDto { Id = 2, Name = "B", Price = 10m } }.Select(p => new Product(p, AccountType.Basic));
            IEnumerable<Product> prem = new List<ProductDto> { new ProductDto { Id = 3, Name = "C", Price = 10m }, new ProductDto { Id =4, Name = "D", Price = 10m } }.Select(p => new Product(p, AccountType.Premium));
            List<Product> prod = new List<Product>(basic);
            prod.AddRange(prem);
      
            var res = builder.GetVmList(prod);

            Assert.IsTrue(res.Products.Any(x=>x.AccountTypeLabel==AccountType.Basic.ToString()));
            Assert.IsTrue(res.Products.Any(x => x.AccountTypeLabel == AccountType.Premium.ToString()));

        }
    }
}