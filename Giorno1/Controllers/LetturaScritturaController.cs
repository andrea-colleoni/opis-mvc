using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Giorno1.Controllers
{
    public class LetturaScritturaController : Controller
    {
        // GET: LetturaScrittura
        public ActionResult Index()
        {
            return View();
        }

        // GET: LetturaScrittura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LetturaScrittura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LetturaScrittura/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LetturaScrittura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LetturaScrittura/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LetturaScrittura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LetturaScrittura/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
