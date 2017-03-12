using MVCTeamProducts.Business.Managers;
using MVCTeamProducts.Business.Repositories;
using MVCTeamProducts.Business.VmBuilders;
using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using System.Configuration;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using MVCTeamProducts.Models.Domain;

namespace MVCTeamProducts.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            this.kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IProductManager>().To<ProductManager>();
            kernel.Bind<IProductVmBuilder>().To<ProductVmBuilder>();
            kernel.Bind<IAccountRepository<Account>>().To<MySqlLAccouuntRepository>();
            kernel.Bind<IProductRepository>().To<ProductRepositoryDto>();


        }



    }
}