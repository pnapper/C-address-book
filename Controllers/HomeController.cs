using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View("Contacts", allContacts);
    }

    [HttpGet("/contacts")]
    public ActionResult Contacts()
    {
      return View();
    }

    [HttpGet("/contacts/new")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult AddContact()
    {
      Contact newContact = new Contact(Request.Form["contact-name"], int.Parse(Request.Form["contact-phone"]), Request.Form["contact-address"]);
      List<Contact> allContacts = Contact.GetAll();
      return View("Contacts", allContacts);
    }

    [HttpGet("/{id}")]
    public ActionResult ContactDetail(int id)
    {
      Contact contact = Contact.Find(id);
      return View(contact);
    }

    [HttpPost("/contact/delete")]
    public ActionResult ContactDelete(int id)
    {
      Contact contact = Contact.Find(id);
      Contact.Clear();
      return View();
    }

    [HttpPost("/contacts/clear")]
    public ActionResult ContactsClear()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
