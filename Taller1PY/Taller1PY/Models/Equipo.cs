using System.ComponentModel.DataAnnotations;

namespace Taller1PY.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public string AceptaExtranjeros { get; set; }
    }
}
