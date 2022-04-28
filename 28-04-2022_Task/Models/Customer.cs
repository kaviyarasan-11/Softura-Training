using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProductEntity.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
