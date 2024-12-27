using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppAspGroupe1.Models
{
    public class BdAgenceVoyageContext:DbContext
    {
        public BdAgenceVoyageContext():base("ConnAgenceVoyage")
        {

        }

        public DbSet <Chauffeur> Chauffeurs { get; set; }
    }
}