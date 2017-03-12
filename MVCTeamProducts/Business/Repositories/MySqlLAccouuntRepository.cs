using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTeamProducts.Models.Domain;

namespace MVCTeamProducts.Business.Repositories
{
    public class MySqlLAccouuntRepository : IAccountRepository<Account>
    {
        private ProductsContext productContext;
        public MySqlLAccouuntRepository()
        {
            this.productContext = new ProductsContext();
        }
        public Account GetById(int UserId)
        {
            return productContext.Accounts.Find(UserId);
        }
    }
}