using System.ComponentModel.DataAnnotations;
using System.IO.Pipelines;

namespace ViamaticaAPI.MODELS
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public DateTime InicioSesion { get; set; }

    }
}
