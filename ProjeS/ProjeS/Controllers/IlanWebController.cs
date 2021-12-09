using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeS.Models;




namespace ProjeS.Controllers
{
    public class IlanWebController : Controller
    {
        // GET: IlanWeb
        ProjeS.Models.SinavİlanEntities c = new Models.SinavİlanEntities();

        public ActionResult Index()
        {
            var degerler = c.Sinavİlan.ToList();
            return View(degerler);
          
        }
    }
}