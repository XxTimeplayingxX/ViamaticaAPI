namespace ViamaticaAPI.MODELS
{
    public class Post
    {
        public int ID { get; set; }
        public string Título { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Contenido { get; set; }
        public int ComentarioId { get; set; }
        //Propiedad de navegación
        public Comentario Comentario { get; set; }
    }
}
