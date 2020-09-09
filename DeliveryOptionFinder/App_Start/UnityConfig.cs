using DeliveryOptionFinder.Cache;
using DeliveryOptionsDAL.Interfaces;
using DeliveryOptionsDAL.Repositories;
using DeliveryOptionsService.Interfaces;

using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DeliveryOptionFinder
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
               
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //add our dependencies here, that way we dont need to new them up as objects!
            container.RegisterType<IDeliveryOptionsRepository, DeliveryOptionsRepository>();
            container.RegisterType<IDeliveryOptionsService, DeliveryOptionsService.Services.DeliveryOptionsService>();
            container.RegisterType<ICacheService, CacheService>();
            

        }
    }
}