using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller1PY.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }  
        public int Edad { get; set; }
        [ForeignKey("Equipo")]
        public Equipo Equipo { get; set; }

    }
}
