using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParkFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace ParkFinder.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private ParkFinderContext _db;

    public ParksController(ParkFinderContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string location, string dateEstablished, string area, string description)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (dateEstablished != null)
      {
        query = query.Where(entry => entry.DateEstablished == dateEstablished);
      }

      if (area != null)
      {
        query = query.Where(entry => entry.Area == area);
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}