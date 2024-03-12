using System.ComponentModel.DataAnnotations;

namespace ViamaticaAPI.MODELS
{
    public class Comentario
    {
        [Key]
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public string Contenido { get; set; }
        //Propiedad de navegación
        public Usuario Usuario { get; set; }
    }
}
