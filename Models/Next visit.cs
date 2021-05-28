using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MAVRS.Models
{
    [Table("Next visit")]
    public class Nextvisit
    {
        [Key]
        [Required]
        public int ID { get; set; }


        [Display(Name = "National ID", Prompt = "Enter ID here")]
        public int P_national_id { get; set; }


        [Display(Name = "Full names", Prompt = "Full names")]
        [MaxLength(50)]
        public string Full_names { get; set; }



        [Display(Name = "Next visit", Prompt = "Next visit")]
        public string S_national_id { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Phone no", Prompt = "Phone no")]
        public int Phone_no { get; set; }
    }
}
