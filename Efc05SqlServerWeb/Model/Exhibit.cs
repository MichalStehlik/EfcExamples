using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Efc05SqlServerWeb.Model
{
    public class Exhibit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Název")]
        public string Name { get; set; }
        [Display(Name="Rok vytvoření")]
        public int? Year { get; set; }
    }
}
