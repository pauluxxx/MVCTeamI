using MVCTeamProducts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Models.Domain
{
    public class Account
    {
        public int UserId { get; set; }
        public AccountType AccountType { get; set; }
        public Account(AccountDto dto)
        {
            this.UserId = dto.UserId;
            this.AccountType = (AccountType)dto.AccountType;
        }


    }
}