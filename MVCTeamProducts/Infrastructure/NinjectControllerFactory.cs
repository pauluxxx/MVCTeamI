using MVCTeamProducts.Business.Managers;
using MVCTeamProducts.Business.Repositories;
using MVCTeamProducts.Business.VmBuilders;
using MVCTeamProducts.Models.Domain;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MVCTeamProducts.Infrastructure
{
    class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)kernel.Get(controllerType);
        }

        private void AddBindings()
        {
            kernel.Bind<IProductManager>().To<ProductManager>();
            kernel.Bind<IProductVmBuilder>().To<ProductVmBuilder>();
            kernel.Bind<IAccountRepository<Account>>().To<MySqlLAccouuntRepository>();
            kernel.Bind<IProductRepository>().To<MySqlProductsRepository>();

        }
    }
}
