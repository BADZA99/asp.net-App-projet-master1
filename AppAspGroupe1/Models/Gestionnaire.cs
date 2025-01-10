using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace AppAspGroupe1.Models
{
    public class Gestionnaire:Utilisateur

    {
        [Display(Name = "Ninea"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string NineaGestionnaire { get; set; }

        [Display(Name = "Rcm"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string RcmGestionnaire { get; set; }

        [Display(Name = "CNI"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string CNIGestionnaire { get; set; }

    }
}