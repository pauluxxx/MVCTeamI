using MVCTeamProducts.Business.Managers;
using MVCTeamProducts.Business.VmBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTeamProducts.Controllers
{
    public class ProductController : Controller
    {
        IProductManager manager;
        IProductVmBuilder builder;
        public ActionResult Index()
        {
            var prods = manager.GetProductsByType(1);
            var prodVm = builder.GetVmList(prods);
            return View(prodVm);
        }
        public ProductController(IProductManager manager, IProductVmBuilder builder)
        {   this.manager = manager;
            this.builder = builder;
        }
    }
}
