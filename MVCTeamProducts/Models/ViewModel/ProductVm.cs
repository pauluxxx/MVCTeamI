using MVCTeamProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Models.ViewModel
{
    public class ProductVm
    {
        public Product Product { get; set; }
        public string AccountTypeLabel { get { return Product.isPremium?"{Prem}":"Basic";}}
    }
}