using MVCTeamProducts.Infrastructure;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTeamProducts
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
           //Ninject just didn't working with any projects??
            //it was old type of connection
            // DependencyResolver.SetResolver(new NinjectDependencyResolver());
            //var container = ConfigureDependencies(ConfigurationHelper.ConfigureDependencies);

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }
        //StructureMap didt to
        //public static IContainer ConfigureDependencies(Action<ConfigurationExpression> configurationAction)
        //{
        //    //diddsssss
        //    IContainer container = new Container();
        //    container.Configure(configurationAction);
        //    return container;
        //}
    }
}