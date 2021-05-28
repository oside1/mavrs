using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MAVRS.Models
{
    [Table("Mother_status")]
    public class Mother_status
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Mother_status ", Prompt = "Add")]
        public string C_mother_status { get; set; }

    }
}
