using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using MVCTeamProducts.Business.Repositories;
using MVCTeamProducts.Models.Domain;
using MVCTeamProducts.Business.Managers;
using System.Collections;
using System.Collections.Generic;
using MVCTeamProducts.DTO;
namespace MVCTeamProducts.Tests.ManagersTests
{
    [TestClass]
    public class ProductManagerTest
    {
    public interface IFoo
        {
            Account DoSomething(int  h);
            string DoSomethingStringy(string g);

            int GetCount();
            int GetCountThing();
        }
        [TestMethod]
        public void GetGetProductsByTypeBasicAcc()
            {
            var userId = 1;
            Mock<IAccountRepository> fakeAccaunt = new Mock<IAccountRepository>();
           fakeAccaunt.Setup(m => m.GetById(1)).Returns(new Account(new AccountDto { UserId=userId,AccountType=(int)AccountType.Basic}));
            Mock<IProductRepository> fakeProducts = new Mock<IProductRepository>();
            var basicProd = new List<Product> { new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Basic), new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Basic) };
            var prem = new List<Product> { new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Premium), new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Premium) };
            fakeProducts.Setup(m => m.GetProducts()).Returns(basicProd);
            fakeProducts.Setup(m => m.GetPremiumProducts()).Returns(prem);
            
            var productManager = new ProductManager(fakeAccaunt.Object, fakeProducts.Object);
           
            var res = productManager.GetProductsByType(userId);
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count()>0);
            Assert.IsTrue(res.All(x => x.isPremium == false));
            Assert.AreEqual(res.Count(), 2);

        }
        [TestMethod]
        public void GetGetProductsByTypePremAcc()
        {
            var userId = 1;
            Mock<IAccountRepository> fakeAccaunt = new Mock<IAccountRepository>();
            fakeAccaunt.Setup(m => m.GetById(1)).Returns(new Account(new AccountDto { UserId = userId, AccountType = (int)AccountType.Premium }));
            Mock<IProductRepository> fakeProducts = new Mock<IProductRepository>();
            var basicProd = new List<Product> { new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Basic), new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Basic) };
            var prem = new List<Product> { new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Premium), new Product(new ProductDto { Id = 1, Name = "A", Price = 200m }, AccountType.Premium) };
            fakeProducts.Setup(m => m.GetProducts()).Returns(basicProd);
            fakeProducts.Setup(m => m.GetPremiumProducts()).Returns(prem);

            var productManager = new ProductManager(fakeAccaunt.Object, fakeProducts.Object);

            var res = productManager.GetProductsByType(userId);
            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count() > 0);
            Assert.IsTrue(res.Any(x => x.isPremium == false));//prem can be there and basic too
            Assert.IsTrue(res.Any(x => x.isPremium == true));
            Assert.AreEqual(res.Count(), 4);
        }
   
    }
}
