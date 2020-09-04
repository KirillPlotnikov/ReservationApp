using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SemestralkaDataControl.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }
        [Required, StringLength(500, MinimumLength = 50)]
        public string Description { get; set; }
        [Required, Range(0, 23), Display(Name = "Opened from")]
        public int OpenedFrom { get; set; }
        [Required, Range(0, 23), Display(Name = "Opened to")]
        public int OpenedTo { get; set; }
        

        public List<Reservation> Reservations { get; set; }
    }
}
