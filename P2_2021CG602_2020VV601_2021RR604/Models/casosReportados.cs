using System.ComponentModel.DataAnnotations;

namespace P2_2021CG602_2020VV601_2021RR604.Models
{
    public class casosReportados
    {
        [Key]
        public int idCaso { get; set; }
        public int idDepartamento { get; set; }
        public int idGenero { get; set; }
        public int? confirmados { get; set; }
        public int? recuperados { get; set; }
        public int? fallecidos { get; set; }
    }
}
