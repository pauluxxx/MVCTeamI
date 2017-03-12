using MVCTeamProducts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Models.Domain
{
    public class Account
    {
 
        public int AccountId { get; set; }
        public AccountType AccountType { get; set; }
        public Account(AccountDto dto)
        {
            this.AccountId = dto.UserId;
            this.AccountType = (AccountType)dto.AccountType;
        }
        public Account() { }


    }
}