using MVCTeamProducts.Business.Managers;
using MVCTeamProducts.Business.Repositories;
using MVCTeamProducts.Business.VmBuilders;
using MVCTeamProducts.Models.Domain;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTeamProducts.Infrastructure
{
    public class ConfigurationHelper
    {
        public static void ConfigureDependencies(ConfigurationExpression x)
        {
            x.For<IProductManager>().Use<ProductManager>();
            x.For<IProductVmBuilder>().Use<ProductVmBuilder>();
            x.For<IAccountRepository<Account>>().Use<MySqlLAccouuntRepository>();
            x.For<IProductRepository>().Use<ProductRepositoryDto>();
        }
    }
}