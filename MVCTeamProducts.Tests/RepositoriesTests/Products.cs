using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCTeamProducts.Business.Repositories;

namespace MVCTeamProducts.Tests.RepositoriesTests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void GetProducts()
        {
            //arrange
            var prodRep = new ProductRepository();
            //act
            var resProducts = prodRep.GetProducts();
            //assert
            Assert.IsNotNull(resProducts);
            Assert.IsTrue(resProducts.Count()>0);
            Assert.IsFalse(resProducts.Any(x=>x.isPremium==true));
            
        }
        [TestMethod]
        public void GetPremiumProducts()
        {
            //arrange
            var prodRep = new ProductRepository();
            //act
            var resProducts = prodRep.GetPremiumProducts();
            //assert
            Assert.IsNotNull(resProducts);
            Assert.IsTrue(resProducts.Count() > 0);
            Assert.IsTrue(resProducts.All(x => x.isPremium == true));

        }
    }
}
