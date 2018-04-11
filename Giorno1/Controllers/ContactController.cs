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
using Giorno1.Models;
using System.IO;
using System.Data.SqlClient;

namespace Giorno1.Controllers
{
    public class ContactController : Controller
    {
        private Giorno1Context db = new Giorno1Context();

        // GET: Contact
        public async Task<ActionResult> Index()
        {
            var contacts = db.Contacts;//.Include(c => c.Company);
            return View(await contacts.ToListAsync());
        }

        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonResult()
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior,
                MaxJsonLength = Int32.MaxValue
            };
        }

        // GET: Contact
        public ActionResult List()
        {
            var contatti = db.Contacts.Select(c => 
                new ViewContact
                {
                    Cognome = c.Cognome,
                    name = c.Nome,
                    DataNascita = c.DataNascita,
                    Email = c.Email,
                    Company = new ViewCompany
                    {
                        Nome = c.Company.Nome,
                        NumeroDipendenti = c.Company.NumeroDipendenti
                    }
                });
            return Json(contatti, JsonRequestBehavior.AllowGet);
        }
        [OutputCache(Duration = 300)]
        public ActionResult ListByCompany(int companyId)
        {
            var param = new SqlParameter("@companyId", companyId);
            var contattiDb = db
                    .Database
                    .SqlQuery<ViewContact>("sp_ContattiPerCompany @companyId", param).ToList();
            return Json(contattiDb, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// Esempio di trasmissione di un file (in questo caso PDF)
        /// </summary>
        /// <returns></returns>
        public ActionResult Pdf()
        {
            var fs = new FileStream(@"C:\Users\andre\Desktop\Temp\Corsi\Opis\PDFprova.pdf", FileMode.Open);
            FileStreamResult _ret = new FileStreamResult(fs, "application/pdf");
            return _ret;
        }
        // GET: Contact/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Nome");
            ViewBag.Title = "Nuovo contatto";
            ViewBag.ButtonText = "Inserisci";
            return View("Form", new Contact());
        }

        // GET: Contact/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Nome", contact.CompanyId);
            ViewBag.Title = "Modifica " + contact.NomeCompleto;
            ViewBag.ButtonText = "Aggiorna";
            return View("Form", contact);
        }

        // POST: Contact/Create
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId <= 0)
                {
                    ViewBag.Title = "Nuovo contatto";
                    db.Contacts.Add(contact);
                }
                else
                {
                    ViewBag.Title = "Modifica " + contact.NomeCompleto;
                    db.Entry(contact).State = EntityState.Modified;
                }
                await db.SaveChangesAsync();
                
                ViewBag.ButtonText = "Riprova";
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "Nome", contact.CompanyId);
            return View("Form", contact);
        }



        // GET: Contact/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = await db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Contact contact = await db.Contacts.FindAsync(id);
            db.Contacts.Remove(contact);
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
