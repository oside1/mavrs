﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MAVRS.Models
{
    public class Admin
    {
        [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display(Name = "Staff no", Prompt = "e.g. 122333")]
    public int staff_no { get; set; }

    [Required]
    [Display(Name = "Full names", Prompt = "Full names")]
    [MaxLength(50)]
    public string Full_names { get; set; }

    [Required]
    [Display(Name = "Phone number", Prompt = "Phone number")]
    [DataType(DataType.PhoneNumber)]
    public int Phone_number { get; set; }



    [Required]
    [Display(Name = "Password", Prompt = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }



    [Required]
    [Display(Name = "Role", Prompt = "Role")]
    public int Role { get; set; }














}
}
