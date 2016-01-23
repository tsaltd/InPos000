using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InPos000Data;


namespace InPosWebMVC01.Controllers
{
    public class InPosController : Controller
    {
        // GET: InPos
        public ActionResult Index()
        {
            InPos000Data.InPosViewModel model = new InPosViewModel();
            return View(model);
        }
    }
}