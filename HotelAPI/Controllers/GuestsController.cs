using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HotelAPI;
using HotelAPI.Models;

namespace HotelAPI.Controllers
{
    public class GuestsController : ApiController
    {
        private HotelContext db = new HotelContext();

        // GET: api/Guests
        public List<Guest> GetGości()
        {
            return db.Gości.ToList<Guest>();
        }

        // GET: api/Guests/5
        [ResponseType(typeof(Guest))]
        [ActionName("search")]
        public IHttpActionResult GetGuest(string name)
        {
            List<Guest> guest = db.Gości.Where(g => g.Imię == name).ToList();
            if (guest == null)
            {
                return NotFound();
            }

            return Ok(guest);
        }

        [ResponseType(typeof(Guest))]
        [ActionName("search")]
        public IHttpActionResult GetGuest(string name, string city)
        {
            List<Guest> guest = db.Gości.Where(g => g.Imię == name).Where(g => g.Miasto == city).ToList();
            if (guest == null)
            {
                return NotFound();
            }

            return Ok(guest);
        }

        [ActionName("add")]
        public void PostGuest([FromBody] Guest Guest)
        {

            db.Gości.Add(Guest);
            db.SaveChanges();

        }


        /*  // PUT: api/Guests/5
          [ResponseType(typeof(void))]
          public async Task<IHttpActionResult> PutGuest(int id, Guest guest)
          {
              if (!ModelState.IsValid)
              {
                  return BadRequest(ModelState);
              }

              if (id != guest.ID)
              {
                  return BadRequest();
              }

              db.Entry(guest).State = EntityState.Modified;

              try
              {
                  await db.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (!GuestExists(id))
                  {
                      return NotFound();
                  }
                  else
                  {
                      throw;
                  }
              }

              return StatusCode(HttpStatusCode.NoContent);
          }

          // POST: api/Guests
          [ResponseType(typeof(Guest))]
          public async Task<IHttpActionResult> PostGuest(Guest guest)
          {
              if (!ModelState.IsValid)
              {
                  return BadRequest(ModelState);
              }

              db.Gości.Add(guest);
              await db.SaveChangesAsync();

              return CreatedAtRoute("DefaultApi", new { id = guest.ID }, guest);
          }

          // DELETE: api/Guests/5
          [ResponseType(typeof(Guest))]
          public async Task<IHttpActionResult> DeleteGuest(int id)
          {
              Guest guest = await db.Gości.FindAsync(id);
              if (guest == null)
              {
                  return NotFound();
              }

              db.Gości.Remove(guest);
              await db.SaveChangesAsync();

              return Ok(guest);
          }

          protected override void Dispose(bool disposing)
          {
              if (disposing)
              {
                  db.Dispose();
              }
              base.Dispose(disposing);
          }

          private bool GuestExists(int id)
          {
              return db.Gości.Count(e => e.ID == id) > 0;
          }*/
    }
}