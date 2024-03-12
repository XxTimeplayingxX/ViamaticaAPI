using Microsoft.EntityFrameworkCore;
using ViamaticaAPI.MODELS;

namespace ViamaticaAPI.DATA
{
    public class ViaMaticaDbContext : DbContext
    {
        public ViaMaticaDbContext(DbContextOptions<ViaMaticaDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Sembrado de datos para la clase Usuario
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { ID = 5, Nombre = "Ana García", Correo = "ana_garcia@example.com", Contraseña = "contraseña123", InicioSesion = DateTime.Now },
                new Usuario { ID = 6, Nombre = "Juan Martínez", Correo = "juan_martinez@example.com", Contraseña = "456abcDEF", InicioSesion = DateTime.Now },
                new Usuario { ID = 7, Nombre = "María Rodríguez", Correo = "maria_rodriguez@example.com", Contraseña = "qwerty789", InicioSesion = DateTime.Now },
                new Usuario { ID = 8, Nombre = "Luis Hernández", Correo = "luis_hernandez@example.com", Contraseña = "asdfg12345", InicioSesion = DateTime.Now },
                new Usuario { ID = 9, Nombre = "Laura Pérez", Correo = "laura_perez@example.com", Contraseña = "12345678", InicioSesion = DateTime.Now },
                new Usuario { ID = 10, Nombre = "Carlos Sánchez", Correo = "carlos_sanchez@example.com", Contraseña = "password", InicioSesion = DateTime.Now },
                new Usuario { ID = 11, Nombre = "Andrea López", Correo = "andrea_lopez@example.com", Contraseña = "abcd1234", InicioSesion = DateTime.Now },
                new Usuario { ID = 12, Nombre = "David Gómez", Correo = "david_gomez@example.com", Contraseña = "ilovecoding", InicioSesion = DateTime.Now },
                new Usuario { ID = 13, Nombre = "Paula Díaz", Correo = "paula_diaz@example.com", Contraseña = "987654321", InicioSesion = DateTime.Now },
                new Usuario { ID = 14, Nombre = "Javier Fernández", Correo = "javier_fernandez@example.com", Contraseña = "securepassword", InicioSesion = DateTime.Now }
            );

            // Sembrado de datos para la clase Comentario
            modelBuilder.Entity<Comentario>().HasData(
                new Comentario { ID = 1, UsuarioID = 1, Contenido = "Explorando las maravillas de la naturaleza: un viaje a través de la selva amazónica" },
                new Comentario { ID = 2, UsuarioID = 2, Contenido = "Los secretos detrás de las mejores recetas de cocina italiana." },
                new Comentario { ID = 3, UsuarioID = 3, Contenido = "Consejos prácticos para mejorar tu productividad en el trabajo desde casa" },
                new Comentario { ID = 4, UsuarioID = 4, Contenido = "Descubriendo los rincones más pintorescos de Europa: un recorrido por las calles empedradas de Praga" },
                new Comentario { ID = 5, UsuarioID = 5, Contenido = "Cómo mantener un estilo de vida saludable: consejos simples para hacer ejercicio y comer bien" },
                new Comentario { ID = 6, UsuarioID = 6, Contenido = "Las últimas tendencias en moda primavera-verano: looks imprescindibles para esta temporada" },
                new Comentario { ID = 7, UsuarioID = 7, Contenido = "10 destinos exóticos para unas vacaciones inolvidables en el sudeste asiático." },
                new Comentario { ID = 8, UsuarioID = 8, Contenido = "Aprende a tocar la guitarra: consejos para principiantes y recursos útiles" },
                new Comentario { ID = 9, UsuarioID = 9, Contenido = "El arte de la fotografía: capturando momentos y creando recuerdos para toda la vida" },
                new Comentario { ID = 10, UsuarioID = 10, Contenido = "La importancia de la educación financiera: cómo gestionar tus finanzas personales y planificar tu futuro." }


            );

            // Sembrado de datos para la clase Post
            modelBuilder.Entity<Post>().HasData(
                new Post { ID = 1, Título = "El impacto de la inteligencia artificial en la sociedad moderna", FechaPublicacion = DateTime.Now, Contenido = "Desde la automatización de tareas hasta la atención médica personalizada, la inteligencia artificial está transformando la forma en que vivimos y trabajamos. Exploraremos sus aplicaciones actuales y su potencial futuro.", ComentarioId = 1 },
                new Post { ID = 2, Título = "Consejos para mantener un estilo de vida sustentable", FechaPublicacion = DateTime.Now, Contenido = "Descubre cómo reducir tu huella de carbono y vivir de manera más eco-friendly con pequeños cambios en tu día a día, desde la elección de productos hasta la gestión de residuos", ComentarioId = 2 },
                new Post { ID = 3, Título = "El poder de la meditación: cómo encontrar calma en un mundo agitado", FechaPublicacion = DateTime.Now, Contenido = "Exploraremos los beneficios de la meditación para la salud mental y emocional, así como técnicas simples para incorporar la meditación a tu rutina diaria y encontrar paz interior", ComentarioId = 3 },
                new Post { ID = 4, Título = "La importancia del liderazgo inclusivo en el lugar de trabajo", FechaPublicacion = DateTime.Now, Contenido = "Analizaremos cómo fomentar un entorno laboral inclusivo que valore la diversidad y la equidad, y los beneficios que esto puede aportar tanto a los empleados como a la organización en general", ComentarioId = 4 },
                new Post { ID = 5, Título = "Viajando con un presupuesto limitado: consejos para explorar el mundo sin gastar una fortuna", FechaPublicacion = DateTime.Now, Contenido = "Descubre estrategias para planificar viajes económicos, desde encontrar vuelos baratos hasta hospedarte en alojamientos asequibles y disfrutar de experiencias locales sin romper el banco", ComentarioId = 5 },
                new Post { ID = 6, Título = "El futuro del trabajo remoto: desafíos y oportunidades", FechaPublicacion = DateTime.Now, Contenido = "En un mundo cada vez más digital, examinaremos cómo el trabajo remoto está redefiniendo la forma en que las empresas operan y cómo los profesionales pueden adaptarse y prosperar en este nuevo entorno laboral", ComentarioId = 6 },
                new Post { ID = 7, Título = "Los secretos de una alimentación saludable: mitos y realidades", FechaPublicacion = DateTime.Now, Contenido = "Desmitificaremos algunas creencias comunes sobre la nutrición y ofreceremos consejos respaldados por la ciencia para una alimentación equilibrada que promueva la salud y el bienestar", ComentarioId = 7 },
                new Post { ID = 8, Título = "Explorando los misterios del universo: viaje a través de la astronomía", FechaPublicacion = DateTime.Now, Contenido = "Desde los planetas del sistema solar hasta las galaxias distantes, adéntrate en el fascinante mundo de la astronomía y descubre los secretos del cosmos", ComentarioId = 8 },
                new Post { ID = 9, Título = "El arte de la escritura creativa: consejos para desbloquear tu creatividad", FechaPublicacion = DateTime.Now, Contenido = "Aprende técnicas y ejercicios prácticos para superar el bloqueo del escritor, desarrollar personajes convincentes y construir tramas emocionantes en tus historias", ComentarioId = 9 },
                new Post { ID = 10, Título = "Cómo cultivar un jardín urbano: guía paso a paso para principiantes", FechaPublicacion = DateTime.Now, Contenido = "Desde la selección de plantas adecuadas hasta la planificación del espacio y el cuidado diario, te guiaremos en la creación de un hermoso jardín en tu hogar urbano, incluso si tienes poco espacio disponible.", ComentarioId = 10 }
            );

            // Sembrado de datos para la clase Categoria
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { ID = 1, Nombre = "Viajes", PostID = 1 },
                new Categoria { ID = 2, Nombre = "Tecnología", PostID = 2 },
                new Categoria { ID = 3, Nombre = "Salud y bienestar", PostID = 3 },
                new Categoria { ID = 4, Nombre = "Moda y estilo", PostID = 4 },
                new Categoria { ID = 5, Nombre = "Alimentación y nutrición", PostID = 5 },
                new Categoria { ID = 6, Nombre = "Arte y cultura", PostID = 6 },
                new Categoria { ID = 7, Nombre = "Finanzas personales", PostID = 7 },
                new Categoria { ID = 8, Nombre = "Educación y aprendizaje", PostID = 8 },
                new Categoria { ID = 9, Nombre = "Entretenimiento", PostID = 9 },
                new Categoria { ID = 10, Nombre = "Medio ambiente y sostenibilidad", PostID = 10 }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
