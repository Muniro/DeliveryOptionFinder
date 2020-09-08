using DeliveryOptionFinder.Models;
using DeliveryOptionsService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryOptionFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeliveryOptionsService service;

        public HomeController(IDeliveryOptionsService service)
        {
            this.service = service;
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
            var retVal= Json(service.GetDeliveryOptionsByPostCode(code.ToUpper()), JsonRequestBehavior.AllowGet);
            return retVal;
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