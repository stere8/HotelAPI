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
    public class ReservationsController : ApiController
    {
        private HotelContext db = new HotelContext();

        // GET: api/Reservations
        [ActionName("showall")]
        public List<Reservation> GetRezerwacji()
        {
            return db.Rezerwacji.ToList<Reservation>();
        }

        // POST: api/Reservations
        //[ResponseType(typeof(Reservation))]
        [HttpPost]
        [ActionName("add")]
        public void PostReservation([FromBody] Reservation reservation)
        {

            db.Rezerwacji.Add(reservation);
            db.SaveChanges();

        }


        /*  // GET: api/Reservations/5
          [ResponseType(typeof(Reservation))]
          public async Task<IHttpActionResult> GetReservation(int id)
          {
              Reservation reservation = await db.Rezerwacji.FindAsync(id);
              if (reservation == null)
              {
                  return NotFound();
              }

              return Ok(reservation);
          }

          // PUT: api/Reservations/5
          [ResponseType(typeof(void))]
          public async Task<IHttpActionResult> PutReservation(int id, Reservation reservation)
          {
              if (!ModelState.IsValid)
              {
                  return BadRequest(ModelState);
              }

              if (id != reservation.ID)
              {
                  return BadRequest();
              }

              db.Entry(reservation).State = EntityState.Modified;

              try
              {
                  await db.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (!ReservationExists(id))
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

          // POST: api/Reservations
          [ResponseType(typeof(Reservation))]
          public async Task<IHttpActionResult> PostReservation(Reservation reservation)
          {
              if (!ModelState.IsValid)
              {
                  return BadRequest(ModelState);
              }

              db.Rezerwacji.Add(reservation);
              await db.SaveChangesAsync();

              return CreatedAtRoute("DefaultApi", new { id = reservation.ID }, reservation);
          }

          // DELETE: api/Reservations/5
          [ResponseType(typeof(Reservation))]
          public async Task<IHttpActionResult> DeleteReservation(int id)
          {
              Reservation reservation = await db.Rezerwacji.FindAsync(id);
              if (reservation == null)
              {
                  return NotFound();
              }

              db.Rezerwacji.Remove(reservation);
              await db.SaveChangesAsync();

              return Ok(reservation);
          }

          protected override void Dispose(bool disposing)
          {
              if (disposing)
              {
                  db.Dispose();
              }
              base.Dispose(disposing);
          }

          private bool ReservationExists(int id)
          {
              return db.Rezerwacji.Count(e => e.ID == id) > 0;
          }*/
    }
}