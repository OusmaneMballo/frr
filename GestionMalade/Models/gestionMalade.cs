using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.EnterpriseServices.Internal;

namespace GestionMalade.Models
{
    public class gestionMalade: DbContext
    {
        public gestionMalade():base("conn") {

        }
        
            public DbSet<Patient>Patients { get; set; }
        
    }
}