using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionMalade.Models
{
    public class Patient
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Nom"), Required(ErrorMessage ="Ce champ est obligatior!"), MaxLength(30, ErrorMessage ="Max caractere 30")]
        public String nom { get; set; }
        [Display(Name = "Prenom"), Required(ErrorMessage = "Ce champ est obligatior!"), MaxLength(30, ErrorMessage = "Max caractere 40")]
        public String prenom { get; set; }
        [DataType(DataType.MultilineText), Required(ErrorMessage = "Ce champ est obligatior!")]
        public String malaise { get; set; }

    }
}