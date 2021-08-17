using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelAPI.Models
{
    public class Guest
    {
        [Key, Required]
        public int ID { get; set; }
        [Required]
        public string Imię { get; set; }
        [Required]
        public string Nazwizko { get; set; }
        [Required]
        public string Email { get; set; }

        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        

        public Nullable<DateTime> DataUrodzenia { get; set; }
        public string KodPocztowy { get; set; }

        public virtual ICollection<Reservation> Rezerwacji { get; set; }
    }
}