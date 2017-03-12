using MVCTeamProducts.Business.Managers;
using MVCTeamProducts.Business.VmBuilders;
using MVCTeamProducts.Models.Domain;
using MySql.Data.MySqlClient;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTeamProducts.Controllers
{
    public class ProductController : Controller
    {
        [Inject]
        IProductManager manager;
        [Inject]
        IProductVmBuilder builder;
        public ActionResult Index()
        {
            var prods = manager.GetProductsByType(2);
            var prodVm = builder.GetVmList(prods);


            // Create database if not exists
            //using (ProductsContext contextDB = new ProductsContext())
            //{
            //    contextDB.Database.CreateIfNotExists();
            //    // DbSet.AddRange
            //    List<Account> accc = new List<Account>();
            //    List<Product> prod = new List<Product>();

            //    accc.Add(new Account { AccountId = 0, AccountType = 0 });
            //    accc.Add(new Account { AccountId = 1, AccountType = AccountType.Premium });
            //    prod.Add(new Product {ProductId=0,Name="Vv",Price=1m,isPremium=false });
            //    prod.Add(new Product { ProductId = 1, Name = "V2v", Price = 21m, isPremium = true });

            //    contextDB.Accounts.AddRange(accc);
            //  //  contextDB.Prodcuts.AddRange(prod);


            //    contextDB.SaveChanges();
            //}


            return View(prodVm);

        }
        public ProductController(IProductManager manager, IProductVmBuilder builder)
        {
            this.manager = manager;
            this.builder = builder;
        }
    }
}
