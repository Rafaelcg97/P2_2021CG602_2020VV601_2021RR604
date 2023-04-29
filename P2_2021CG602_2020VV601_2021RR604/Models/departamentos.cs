using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P2_2021CG602_2020VV601_2021RR604.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int idDepartamento { get; set; }
        [Display(Name ="Departamentos")] 
        public string? nombreDepartamento { get; set; }
        
    }
}
