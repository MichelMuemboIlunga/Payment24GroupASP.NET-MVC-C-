using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbPaymentCustomersRecords.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Customers()
        {
            dbpaymentsEntities dbpayments = new dbpaymentsEntities();

            var data = dbpayments.prcShowProductSummaryWithRanks();
            return View(data);
        }
    }
}