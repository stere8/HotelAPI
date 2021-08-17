namespace HotelAPI.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelAPI.HotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HotelAPI.HotelContext context)
        {
            var Gości = new List<Guest>
             {
                 new Guest {Imię="Kat", Nazwizko="McLin", Email="k.mackin@gmail.com",  },
                 new Guest {Imię="Richard", Nazwizko="King", Email="richard.k@gmail.com",  },
                 new Guest {Imię="Dominque", Nazwizko="McIntosh", Email="dom.m@gmail.com",  }

             };

             Gości.ForEach(g => context.Gości.Add(g));
             context.SaveChanges();

             var Rezerwacji = new List<Reservation>
             {
                 new Reservation {DatyUtworzenia = DateTime.Now, Cena = 200, DataZameldowania = DateTime.Parse("2021-02-06"), DataWymeldowania = DateTime.Parse("2021-03-06"), KodRezerwacji= "4580204574" , Waluta = Waluta.CZK  },
                 new Reservation {DatyUtworzenia = DateTime.Now, Cena = 200, DataZameldowania = DateTime.Parse("2021-04-06"), DataWymeldowania = DateTime.Parse("2021-04-16"), KodRezerwacji= "4564204574" , Waluta = Waluta.DKK  },
                 new Reservation {DatyUtworzenia = DateTime.Now, Cena = 200, DataZameldowania = DateTime.Parse("2021-12-06"), DataWymeldowania = DateTime.Parse("2021-12-09"), KodRezerwacji= "4573204574" , Waluta = Waluta.GBP  },
                 new Reservation {DatyUtworzenia = DateTime.Now, Cena = 200, DataZameldowania = DateTime.Parse("2021-09-06"), DataWymeldowania = DateTime.Parse("2021-10-06"), KodRezerwacji= "3694204574" , Waluta = Waluta.PLN  }
             };

             Rezerwacji.ForEach(r => context.Rezerwacji.Add(r));
             context.SaveChanges();
             }
         }
        }
  
