using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller1PY.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        [Range(14,40)]
        public int Edad { get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
