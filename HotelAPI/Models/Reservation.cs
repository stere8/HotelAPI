using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelAPI.Models
{
    public enum Waluta
    {
        EUR, USD, PLN, GBP, CHF, SEK, NOK, DKK, CZK
    }

    public class Reservation
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(10), Required]
        public string KodRezerwacji { get; set; }
        [Required]
        public Nullable<DateTime> DatyUtworzenia { get; set; }
        [Required]
        public double Cena { get; set; }
        [Required]
        public Nullable<DateTime> DataZameldowania { get; set; }
        [Required]
        public Nullable<DateTime> DataWymeldowania { get; set; }
        [Required]
        public Waluta Waluta { get; set; }

        public string Prowizja { get; set; }
        public string Źródło { get; set; }

        public int GoścID { get; set; }
        public virtual ICollection<Guest> Gości { get; set; }
    }
}