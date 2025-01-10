using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AppAspGroupe1.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }

        [Display (Name ="Nom"),Required(ErrorMessage ="*"),MaxLength(80)]
        public string NomUtilisateur { get;set; }

        [Display(Name = "Prenom"), Required(ErrorMessage = "*"), MaxLength(80)]
        public string PrenomUtilisateur { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email"), Required(ErrorMessage = "*"), MaxLength(80)]
        public string EmailUtilisateur { get;  set; }


        [Display(Name = "Telephone"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string TelUtilisateur { get; set; }




    }
}