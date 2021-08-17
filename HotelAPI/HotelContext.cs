using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelAPI.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;


namespace HotelAPI
{
    public class HotelContext : DbContext
    {
        /* public HotelContext() : base("name=HotelContext")
         {
             Database.SetInitializer<HotelContext>(new DropCreateDatabaseIfModelChanges<HotelContext>());
         }*/
        public DbSet<Reservation> Rezerwacji { get; set; }
        public DbSet<Guest> Gości { get; set; }
    }
}