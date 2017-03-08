using MVCTeamProducts.DTO;
using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Business.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private IList<AccountDto> accounts = new List<AccountDto>
        {
            new AccountDto{UserId=1,AccountType=(int)AccountType.Basic},
            new AccountDto{UserId=2,AccountType=(int)AccountType.Premium}
        };
        public Account GetById(int userId)
        {
            var accountDto = accounts.SingleOrDefault(x => x.UserId == userId);
            return accountDto!=null?new Account(accountDto):null;
        }
    }
}