using MVCTeamProducts.Infrastructure;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;
using System;
using System.Data.Entity;

namespace MVCTeamProducts
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductsContext, Configuration>());

            //Ninject
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
            //Structure Map vs Ninject
        //    var container = ConfigureDependencies(ConfigurationHelper.ConfigureDependencies);
        //    DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
        }

        private IContainer ConfigureDependencies(Action<ConfigurationExpression> configureDependencies)
        {
            IContainer container = new Container();
            container.Configure(configureDependencies);
            return container;
        }
    }
}