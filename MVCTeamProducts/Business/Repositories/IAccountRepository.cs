using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTeamProducts.Business.Repositories
{
    public interface IAccountRepository <T> where T: class
    {
        
      
        Account GetById(int UserId);
    }
}
