using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace AppAspGroupe1.Models
{
    public class Admin:Utilisateur
    {
        [Display(Name = "Matricule"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string MatriculeAdmin { get; set; }
    }
}