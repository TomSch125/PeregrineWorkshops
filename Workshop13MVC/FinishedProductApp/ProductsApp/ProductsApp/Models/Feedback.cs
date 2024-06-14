using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Feedback
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "name required")]
        [DisplayName( "Name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "email required")]
        [DisplayName("Email name")]
        [StringLength(30)]
        public string email { get; set; }
        [Required(ErrorMessage = "comment required")]
        [DisplayName("Comment")]
        [StringLength(240)]
        public string comment { get; set; }
    }
}