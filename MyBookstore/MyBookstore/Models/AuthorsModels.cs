using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class AuthorsModels
    {
        [Key]
        public int ID { get; set; }
        
        [Display(Name ="LastName")]
        [MaxLength(40, ErrorMessage ="Up to 40 characters only")]
        [Required(ErrorMessage ="Required")]
        public string LastName { get; set; }


        [Display(Name ="FisrtName")]
        [MaxLength(20, ErrorMessage = "Invalid character lenght")]
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }


        [Display(Name ="Phone")]
        [MaxLength(12, ErrorMessage = "Invalid character lenght")]
        [Required(ErrorMessage = "Required")]
        public string Phone { get; set; }


        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(40, ErrorMessage = "Invalid character lenght")]
        public string Address { get; set; }


        [Display(Name ="City")]
        [MaxLength(20, ErrorMessage = "Invalid character lenght")]
        public string  City { get; set; }

        [Display(Name ="State")]
        [MaxLength(2, ErrorMessage = "Invalid character lenght")]
        public string  State { get; set; }


        [Display(Name ="Zip")]
        [MaxLength(5, ErrorMessage = "Invalid character lenght")]
        public string  Zip { get; set; }

    }
}