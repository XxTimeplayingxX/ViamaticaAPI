namespace ViamaticaAPI.MODELS
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int PostID { get; set; }
        //Propiedad de navegación
        public Post Post { get; set; }
    }
}
