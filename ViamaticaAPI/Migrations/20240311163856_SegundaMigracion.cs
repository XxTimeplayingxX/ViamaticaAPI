using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ViamaticaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario_id",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "IdPost",
                table: "Categorias");

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "ID", "Contenido", "UsuarioID" },
                values: new object[,]
                {
                    { 1, "Explorando las maravillas de la naturaleza: un viaje a través de la selva amazónica", 1 },
                    { 2, "Los secretos detrás de las mejores recetas de cocina italiana.", 2 },
                    { 3, "Consejos prácticos para mejorar tu productividad en el trabajo desde casa", 3 },
                    { 4, "Descubriendo los rincones más pintorescos de Europa: un recorrido por las calles empedradas de Praga", 4 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "ID", "Contraseña", "Correo", "InicioSesion", "Nombre" },
                values: new object[,]
                {
                    { 5, "contraseña123", "ana_garcia@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9953), "Ana García" },
                    { 6, "456abcDEF", "juan_martinez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9969), "Juan Martínez" },
                    { 7, "qwerty789", "maria_rodriguez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9971), "María Rodríguez" },
                    { 8, "asdfg12345", "luis_hernandez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9973), "Luis Hernández" },
                    { 9, "12345678", "laura_perez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9974), "Laura Pérez" },
                    { 10, "password", "carlos_sanchez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9976), "Carlos Sánchez" },
                    { 11, "abcd1234", "andrea_lopez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9978), "Andrea López" },
                    { 12, "ilovecoding", "david_gomez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9979), "David Gómez" },
                    { 13, "987654321", "paula_diaz@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9981), "Paula Díaz" },
                    { 14, "securepassword", "javier_fernandez@example.com", new DateTime(2024, 3, 11, 11, 38, 56, 454, DateTimeKind.Local).AddTicks(9983), "Javier Fernández" }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "ID", "Contenido", "UsuarioID" },
                values: new object[,]
                {
                    { 5, "Cómo mantener un estilo de vida saludable: consejos simples para hacer ejercicio y comer bien", 5 },
                    { 6, "Las últimas tendencias en moda primavera-verano: looks imprescindibles para esta temporada", 6 },
                    { 7, "10 destinos exóticos para unas vacaciones inolvidables en el sudeste asiático.", 7 },
                    { 8, "Aprende a tocar la guitarra: consejos para principiantes y recursos útiles", 8 },
                    { 9, "El arte de la fotografía: capturando momentos y creando recuerdos para toda la vida", 9 },
                    { 10, "La importancia de la educación financiera: cómo gestionar tus finanzas personales y planificar tu futuro.", 10 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "ComentarioId", "Contenido", "FechaPublicacion", "Título" },
                values: new object[,]
                {
                    { 1, 1, "Desde la automatización de tareas hasta la atención médica personalizada, la inteligencia artificial está transformando la forma en que vivimos y trabajamos. Exploraremos sus aplicaciones actuales y su potencial futuro.", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(179), "El impacto de la inteligencia artificial en la sociedad moderna" },
                    { 2, 2, "Descubre cómo reducir tu huella de carbono y vivir de manera más eco-friendly con pequeños cambios en tu día a día, desde la elección de productos hasta la gestión de residuos", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(182), "Consejos para mantener un estilo de vida sustentable" },
                    { 3, 3, "Exploraremos los beneficios de la meditación para la salud mental y emocional, así como técnicas simples para incorporar la meditación a tu rutina diaria y encontrar paz interior", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(184), "El poder de la meditación: cómo encontrar calma en un mundo agitado" },
                    { 4, 4, "Analizaremos cómo fomentar un entorno laboral inclusivo que valore la diversidad y la equidad, y los beneficios que esto puede aportar tanto a los empleados como a la organización en general", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(186), "La importancia del liderazgo inclusivo en el lugar de trabajo" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "ID", "Nombre", "PostID" },
                values: new object[,]
                {
                    { 1, "Viajes", 1 },
                    { 2, "Tecnología", 2 },
                    { 3, "Salud y bienestar", 3 },
                    { 4, "Moda y estilo", 4 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "ComentarioId", "Contenido", "FechaPublicacion", "Título" },
                values: new object[,]
                {
                    { 5, 5, "Descubre estrategias para planificar viajes económicos, desde encontrar vuelos baratos hasta hospedarte en alojamientos asequibles y disfrutar de experiencias locales sin romper el banco", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(187), "Viajando con un presupuesto limitado: consejos para explorar el mundo sin gastar una fortuna" },
                    { 6, 6, "En un mundo cada vez más digital, examinaremos cómo el trabajo remoto está redefiniendo la forma en que las empresas operan y cómo los profesionales pueden adaptarse y prosperar en este nuevo entorno laboral", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(189), "El futuro del trabajo remoto: desafíos y oportunidades" },
                    { 7, 7, "Desmitificaremos algunas creencias comunes sobre la nutrición y ofreceremos consejos respaldados por la ciencia para una alimentación equilibrada que promueva la salud y el bienestar", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(191), "Los secretos de una alimentación saludable: mitos y realidades" },
                    { 8, 8, "Desde los planetas del sistema solar hasta las galaxias distantes, adéntrate en el fascinante mundo de la astronomía y descubre los secretos del cosmos", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(193), "Explorando los misterios del universo: viaje a través de la astronomía" },
                    { 9, 9, "Aprende técnicas y ejercicios prácticos para superar el bloqueo del escritor, desarrollar personajes convincentes y construir tramas emocionantes en tus historias", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(194), "El arte de la escritura creativa: consejos para desbloquear tu creatividad" },
                    { 10, 10, "Desde la selección de plantas adecuadas hasta la planificación del espacio y el cuidado diario, te guiaremos en la creación de un hermoso jardín en tu hogar urbano, incluso si tienes poco espacio disponible.", new DateTime(2024, 3, 11, 11, 38, 56, 455, DateTimeKind.Local).AddTicks(196), "Cómo cultivar un jardín urbano: guía paso a paso para principiantes" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "ID", "Nombre", "PostID" },
                values: new object[,]
                {
                    { 5, "Alimentación y nutrición", 5 },
                    { 6, "Arte y cultura", 6 },
                    { 7, "Finanzas personales", 7 },
                    { 8, "Educación y aprendizaje", 8 },
                    { 9, "Entretenimiento", 9 },
                    { 10, "Medio ambiente y sostenibilidad", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.AddColumn<int>(
                name: "Usuario_id",
                table: "Comentarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPost",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
