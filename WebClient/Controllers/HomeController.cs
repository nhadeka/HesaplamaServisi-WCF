using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int sayi1,int sayi2,string islem)
        {
            double sonuc = 0;
            WebClient.ServiceHesap.HesaplamaServiceClient ser = new ServiceHesap.HesaplamaServiceClient();
            if (islem == "+")
            {
                sonuc = ser.Toplama(sayi1, sayi2);
            }
            if (islem == "-")
            {
                sonuc = ser.Cikarma(sayi1, sayi2);
            }
            if (islem == "*")
            {
                sonuc = ser.Carpma(sayi1, sayi2);
            }
            if (islem == "/")
            {
                sonuc = ser.Bolme(sayi1, sayi2);
            }
            ViewBag.Sonuc = sonuc;
            return View();
        }
    }
}