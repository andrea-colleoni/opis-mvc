using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Giorno1Oggetti;

namespace Giorno1.Controllers
{
    public class CompanyController : Controller
    {
        private Giorno1Context db = new Giorno1Context();

        // GET: Company
        public async Task<ActionResult> Index()
        {
            return View(await db.Companies.ToListAsync());
        }

        // GET: Company
        public ActionResult List()
        {
            return PartialView("_List", db.Companies.ToList());
        }

        // GET: Company/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = await db.Companies.FindAsync(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Nuova company";
            ViewBag.ButtonText = "Crea";
            return View("Form", new Company());
        }

        // GET: Company/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = await db.Companies.FindAsync(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = "Modifica " + company.Nome;
            ViewBag.ButtonText = "Aggiorna";
            return View("Form", company);
        }

        // POST: Company/Create
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(Company company)
        {
            if (ModelState.IsValid)
            {
                if (company.CompanyId <= 0)
                {
                    ViewBag.Title = "Nuova company";
                    db.Companies.Add(company); // insert
                }
                else
                {
                    ViewBag.Title = "Modifica " + company.Nome;
                    db.Entry(company).State = EntityState.Modified; // update
                }
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            ViewBag.ButtonText = "Riprova";
            return View("Form", company);
        }

        // GET: Company/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = await db.Companies.FindAsync(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Company company = await db.Companies.FindAsync(id);
            db.Companies.Remove(company);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
