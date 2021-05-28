using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MAVRS.Models
{
    [Table("Mothers")]
    public class Mothers
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Full Names", Prompt = "Full Names")]
        [MaxLength(30)]
        public string Full_Names { get; set; }

        [Key]
        [Required]
        [Display(Name = "National ID", Prompt = "ID")]
        [MaxLength(8)]
        public int ID { get; set; }




        [Display(Name = "Age", Prompt = "Age")]
        public int Age { get; set; }




        [Display(Name = "Location", Prompt = "Location")]
        public string Location { get; set; }


        [Required]
        [Display(Name = "Phone number", Prompt = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone_number { get; set; }


        [Display(Name = "Date", Prompt = "Date")]
        [DataType(DataType.DateTime)]
        public string Date { get; set; }

        [Required]
        [Display(Name = "EDD", Prompt = "EDD")]
        [DataType(DataType.DateTime)]
        public string EDD { get; set; }



        [Required]
        [Display(Name = "Next Visit", Prompt = "Next Visit")]
        [DataType(DataType.DateTime)]
        public string Next_Visit { get; set; }











    }
}
