using System;
using System.Web.Mvc;

namespace MvcServices.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
