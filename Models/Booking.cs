using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientBook.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookingid { get; set; }
        public int clientid { get; set; }
        public virtual Client Client { get; set; } //Foreign Key

        public DateTime bookingday { get; set; }

        public string description { get; set; }
    }
}