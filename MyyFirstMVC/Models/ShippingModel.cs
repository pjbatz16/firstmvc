using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyfirstMVC.Models
{
    public class ShippingModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }

        [Required, StringLength(100)]
        public string Company { get; set; }

        [Required]
        public string PostalCode { get; set; }

        
        


    }
}
