using DeliveryOptionFinder.Cache;
using DeliveryOptionFinder.Models;
using DeliveryOptionsService.Interfaces;
using Newtonsoft.Json;
using System.Linq;
using System.Web.Mvc;

namespace DeliveryOptionFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeliveryOptionsService service;
        private ICacheService cacheService;

        public HomeController(IDeliveryOptionsService service, ICacheService cacheService)
        {
            this.service = service;
            this.cacheService = cacheService;
        }
        public ActionResult Index()
        {
            
            return View();
        }

        public JsonResult DeliveryOptions(string filter = "")
        {
           
            var list = (from postCode in service.GetDeliveryOptionsByPostCode(filter)
                        select new DeliveryItem()
                        {                      
                            DeliveryAvailable = postCode.DeliveryAvailable
                        }).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(
         [Bind(Prefix = "id")] string code)
        {
        
            //Note this is too simplified but the code will grab the data and add to cache if not find, otherwise it will add to cache!
            return  Json(cacheService.GetOrSet(code, () => service.GetDeliveryOptionsByPostCode(code.ToUpper())),JsonRequestBehavior.AllowGet);
            
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}