using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace P2_2021CG602_2020VV601_2021RR604.Models
{
    public class generos
    {
        [Key]
        [Display(Name = "ID")]
        public int idGenero { get; set; }
        [Display(Name = "Genero")]
        public string? nombreGenero { get; set; }

    }
}
