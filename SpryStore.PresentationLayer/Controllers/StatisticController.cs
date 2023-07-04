using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;

namespace SpryStore.PresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context context= new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.productCount=context.Products.Count();
            //Select * from Products where CategoryID=(Select CategoryID from Categories where CategoryName='Elektronik')
            ViewBag.productCountByElectronic = context.Products.Where(x => x.Category.CategoryName == "Elektronik").Count();
            ViewBag.priceUnder5000=context.Products.Where(x=>x.Price<=5000).Count();
            ViewBag.avgPrice=context.Products.Average(x=>x.Price);
            return View();
        }
    }
}
