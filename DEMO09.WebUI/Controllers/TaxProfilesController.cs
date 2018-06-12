
using DEMO09.BusinessInterfaces;
using DEMO09.Types;
using System.Web.Mvc;
using System;
using System.Net;

namespace DEMO09.WebUI.Controllers
{
    public class TaxProfilesController : Controller
    {
        private readonly ITaxProfileProcessor _TaxProfileProcessor;

        public TaxProfilesController(ITaxProfileProcessor TaxProfileProcessor)
        {
            _TaxProfileProcessor = TaxProfileProcessor;
        }

    
        // GET: TaxProfiles
        [HttpGet]
        public ActionResult Index()
        {
            return View(_TaxProfileProcessor.FindAllTaxProfiles());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TaxProfileType item)
        {
            try
            {
                _TaxProfileProcessor.AddTaxProfile(item);
                ViewData["Suscess"] = "Se dio de alta el perfil satisfactoriamente";
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
            //return View("Suscess");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            TaxProfileType item = _TaxProfileProcessor.FindTaxProfileById(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(TaxProfileType item)
        {
            if(_TaxProfileProcessor.FindTaxProfileByIdentification(item.Identification)!=null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                _TaxProfileProcessor.UpdateTaxProfile(item);
                ViewData["Suscess"] = "Se actualizó el perfil satisfactoriamente";
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
            //return View("Suscess");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            TaxProfileType item = _TaxProfileProcessor.FindTaxProfileById(Id);
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmation(int Id, TaxProfileType item)
        {
            try
            {
                _TaxProfileProcessor.RemoveTaxProfile(Id);
                ViewData["Suscess"] = "Se eliminó el perfil satisfactoriamente";
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
            //return View("Suscess");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            TaxProfileType item = _TaxProfileProcessor.FindTaxProfileById(Id);
            return View(item);
        }


    }
}