using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace CdOrganizer.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/contacts")]
    public ActionResult Names()
    {
      List<Album> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/contacts/new")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/contacts")]
    public ActionResult AddContact()
    {
      Contact newContact = new Contact(Request.Form["new-contact"]);
      List<Contact> allContacts = Contact.GetAll();
      return View("Contacts", allContacts);
    }
  }
}
