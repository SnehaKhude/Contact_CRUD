using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactApp_Client.Models;
using ContactApp_Client.ViewModels;

namespace ContactApp_Client.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            ContactClient cc = new ContactClient();
            ViewBag.listContacts = cc.FindAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ContactViewModel cvm)
        {
            cvm.contact.Status = true;
            ContactClient cc = new ContactClient();
            cc.Create(cvm.contact);
            return RedirectToAction("Index");
            
        }
                
        public ActionResult Delete(int id)
        {
            ContactClient cc = new ContactClient();
            cc.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ContactClient cc = new ContactClient();
            ContactViewModel cvm = new ContactViewModel();
            cvm.contact = cc.Find(id);
            return View("Edit", cvm);
        }

        [HttpPost]
        public ActionResult Edit(ContactViewModel cvm)
        {
            cvm.contact.Status = true;
            ContactClient cc = new ContactClient();
            cc.Edit(cvm.contact);
            return RedirectToAction("Index");
        }
    }
}