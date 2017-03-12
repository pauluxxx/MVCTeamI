using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCTeamProducts.Business.Repositories;
using MVCTeamProducts.Models.Domain;

namespace MVCTeamProducts.Tests.RepositoriesTests
{
    [TestClass]
    public class Accounts
    {
        //we hard code the user with id=1 , id=2
        [TestMethod]
        public void GetById()
        {
            IAccountRepository<Account> rep = new AccountRepositoryDto();
            var userId =1;
            var resById = rep.GetById(userId);
            Assert.AreEqual(resById.AccountId, userId);
            userId = 2;
            resById = rep.GetById(userId);
            Assert.AreEqual(resById.AccountId, userId);
            userId = 1002;
            resById = rep.GetById(userId);
            Assert.IsNull(resById);
            
        }
    }
}
