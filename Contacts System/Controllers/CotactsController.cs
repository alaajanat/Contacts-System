using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contacts_System.Models;
namespace Contacts_System.Controllers
{
    public class CotactsController : Controller
    {
        // GET: Cotacts
        ContactsFunctions cf = new ContactsFunctions();
        public ActionResult Index()
        {
            ViewBag.Title = "contacts";
            List<Contacts> ls = cf.GetContacts();
            return View(ls);
        }
        public ActionResult Create()
        {
            ViewBag.Title = "New Contact";
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contacts c )
        {
            cf.AddContact(c);
            return RedirectToAction("index");
            
        }
        public ActionResult Update(int id)
        {
            ViewBag.Title = "Update Contact";
            ContactsDbContext cc = new ContactsDbContext();
            Contacts c = cc.contacts.FirstOrDefault(s => s.id == id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Update(Contacts c)
        {           
            cf.Update(c);
            return RedirectToAction("index");

        }
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete Contact";
            ContactsDbContext cc = new ContactsDbContext();
            Contacts c = cc.contacts.FirstOrDefault(s => s.id == id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Delete(Contacts c)
        {
            cf.Delete(c);
            return RedirectToAction("index");

        }
    }
}