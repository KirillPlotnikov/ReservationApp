using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SemestralkaDataControl.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Date and time")]
        public DateTime DateAndTime { get; set; }
        [Required, Display(Name = "Client name"), StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^\w{1,}$", ErrorMessage = "Minimum 1 character is required")]
        public string ClientName { get; set; }
        [Required, Display(Name = "Client surname"), StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^\w{1,}$", ErrorMessage = "Minimum 1 character is required")]
        public string ClientSurname { get; set; }
        [Required, Display(Name = "Client email"), EmailAddress]
        public string ClientEmail { get; set; }
        [Required, Display(Name = "Client's phone number"), RegularExpression(@"^\+\d{3} \d{3} \d{3} \d{3}$")]
        public string ClientPhone { get; set; }
        [StringLength(500, MinimumLength = 0)]
        public string Description { get; set; }
        [Required]
        public int RoomId { get; set; }

        public Room Room { get; set; }

    }
}
