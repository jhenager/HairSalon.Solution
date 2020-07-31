using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName").Count();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (ModelState.IsValid) {
        _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
      }
      return View(client);
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(thisItem);
    }

  }
}