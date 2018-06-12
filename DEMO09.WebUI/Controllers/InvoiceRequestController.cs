using DEMO09.BusinessInterfaces;
using DEMO09.Types;
using System.Web.Mvc;
using System;
using System.Net;

namespace DEMO09.WebUI.Controllers
{
    public class InvoiceRequestController : Controller
    {
        private readonly IInvoiceRequestProcessor _process;

        public InvoiceRequestController(IInvoiceRequestProcessor process)
        {
            _process = process;
        }


        public ActionResult Index()
        {
            return View(_process.FindAllInvoiceRequest());
        }

    }
}
