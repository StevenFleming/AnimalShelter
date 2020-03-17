using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(ToDoListContext db)
    {
        _db = db;
    }

    
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}