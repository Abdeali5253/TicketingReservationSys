using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingReservationSys
{
    public class Validate
    {
       
        [Required]
        
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [Range(6,20)]
        public string Username { get; set; }
        [Required]
        [Range(6, 200)]
        public string Password { get; set; }
        [Required]
        [Range(6, 200)]
        public string Repassword { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        
        

    }
}
