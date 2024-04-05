using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoCore10AbrilBack.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<IdentityRole> roles = new List<IdentityRole>() {
                new IdentityRole { Name = "Administrador", NormalizedName = "ADMINISTRADOR" },
                new IdentityRole { Name = "Visitante", NormalizedName = "VISITANTE" },
                new IdentityRole { Name = "Abonado", NormalizedName = "ABONADO" },
                new IdentityRole { Name = "Entrenador", NormalizedName = "ENTRENADOR" },
                new IdentityRole { Name = "Jugador", NormalizedName = "JUGADOR" },
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            List<Abonado> abonados = new List<Abonado>
            {
                new Abonado { AbonadoId = 1, Precio = 100, AbonadoNombre = "Juan", AbonadoApellido = "Pérez", AbonadoTelefono = "123456789", AbonadoUser = "JuanAbonado" },
                new Abonado { AbonadoId = 2, Precio = 150, AbonadoNombre = "María", AbonadoApellido = "López", AbonadoTelefono = "987654321", AbonadoUser = "MariaAbonado" },
                new Abonado { AbonadoId = 3, Precio = 120, AbonadoNombre = "Carlos", AbonadoApellido = "Gómez", AbonadoTelefono = "555666777", AbonadoUser = "CarlosAbonado" },
                new Abonado { AbonadoId = 4, Precio = 130, AbonadoNombre = "Laura", AbonadoApellido = "Díaz", AbonadoTelefono = "111222333", AbonadoUser = "LauraAbonado" },
                new Abonado { AbonadoId = 5, Precio = 110, AbonadoNombre = "David", AbonadoApellido = "Sánchez", AbonadoTelefono = "999888777", AbonadoUser = "DavidAbonado" },
                new Abonado { AbonadoId = 6, Precio = 140, AbonadoNombre = "Elena", AbonadoApellido = "Fernández", AbonadoTelefono = "444555666", AbonadoUser = "ElenaAbonado" },
                new Abonado { AbonadoId = 7, Precio = 125, AbonadoNombre = "Miguel", AbonadoApellido = "Rodríguez", AbonadoTelefono = "777888999", AbonadoUser = "MiguelAbonado" },
                new Abonado { AbonadoId = 8, Precio = 145, AbonadoNombre = "Sara", AbonadoApellido = "Martínez", AbonadoTelefono = "666555444", AbonadoUser = "SaraAbonado" },
                new Abonado { AbonadoId = 9, Precio = 115, AbonadoNombre = "Diego", AbonadoApellido = "García", AbonadoTelefono = "333222111", AbonadoUser = "DiegoAbonado" },
                new Abonado { AbonadoId = 10, Precio = 135, AbonadoNombre = "Carmen", AbonadoApellido = "López", AbonadoTelefono = "888999111", AbonadoUser = "CarmenAbonado" }
            };
            modelBuilder.Entity<Abonado>().HasData(abonados);

            // Sembrar datos de Gastos
            List<Gasto> gastos = new List<Gasto>
        {
            new Gasto { GastoId = 1, GastoNombre = "📉Material deportivo", Cantidad=2000 },
            new Gasto { GastoId = 2, GastoNombre = "📉Pago de árbitros", Cantidad=20000 },
            new Gasto { GastoId = 3, GastoNombre = "📉Alquiler del campo de entrenamiento", Cantidad = 500 },
new Gasto { GastoId = 4, GastoNombre = "📉Viaje para torneo fuera de la ciudad",  Cantidad = 1500 },
new Gasto { GastoId = 5, GastoNombre = "📉Sueldo de Jugadores",  Cantidad = 1500000 },
new Gasto { GastoId = 6, GastoNombre = "📉Sueldo del Cuerpo Tecnico", Cantidad = 250000 },
new Gasto { GastoId = 7, GastoNombre = "📉Sueldo del Entrenador",  Cantidad = 15000 },
new Gasto { GastoId = 8, GastoNombre = "📉Viaje para torneo fuera de la ciudad", Cantidad = 1500 },
new Gasto { GastoId = 9, GastoNombre = "📈Venta de entradas en partidos locales", Cantidad = 3000 },
new Gasto { GastoId = 10, GastoNombre = "📉Mantenimiento de equipamiento", Cantidad = 1000 },
new Gasto { GastoId = 11, GastoNombre = "📈Donación de un miembro del equipo", Cantidad = 1000 },
new Gasto { GastoId = 12, GastoNombre = "📈Subvención del gobierno local", Cantidad = 20000 },
new Gasto { GastoId = 13, GastoNombre = "📈Venta de productos de merchandising", Cantidad = 200 },
new Gasto { GastoId = 14, GastoNombre = "📈Entradas", Cantidad = 20000 },
new Gasto { GastoId = 15, GastoNombre = "📈Beneficios por campeonatos", Cantidad = 2000000 }
        };
            modelBuilder.Entity<Gasto>().HasData(gastos);

            // Sembrar datos de Jugadores
            List<Jugador> jugadores = new List<Jugador>
            {
                new Jugador { JugadorId = 1, JugadorSueldo = 2000, JugadorNombre = "Luis", JugadorApellido = "Martínez", JugadorUser = "LuisJugador", Lesionado = Lesionado.No, ImageUrl="~/images/5cb68fa1-dac5-4c6e-9faf-a083483d0486.png" },
                new Jugador { JugadorId = 2, JugadorSueldo = 1800, JugadorNombre = "Ana", JugadorApellido = "García", JugadorUser = "AnaJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/02186b80-325e-474c-8282-c3c78f53c685.png" },
                new Jugador { JugadorId = 3, JugadorSueldo = 1800, JugadorNombre = "Pedro", JugadorApellido = "Gómez", JugadorUser = "PedroJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/0114cc3f-4c78-4a63-b651-cfad67481440.png" },
                new Jugador { JugadorId = 4, JugadorSueldo = 2200, JugadorNombre = "Sara", JugadorApellido = "Hernández", JugadorUser = "SaraJugador", Lesionado = Lesionado.No, ImageUrl="~/images/432fdf64-3cd4-4f91-8fdd-f97f2592d635.png" },
                new Jugador { JugadorId = 5, JugadorSueldo = 1900, JugadorNombre = "Carlos", JugadorApellido = "Díaz", JugadorUser = "CarlosJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/84e8ff71-7868-439b-8511-817099d5b2a8.png" },
                new Jugador { JugadorId = 6, JugadorSueldo = 2100, JugadorNombre = "Elena", JugadorApellido = "Rodríguez", JugadorUser = "ElenaJugador", Lesionado = Lesionado.No, ImageUrl="~/images/62b27d3e-a213-441b-8d32-d39c1ba6730f.png" },
                new Jugador { JugadorId = 7, JugadorSueldo = 2000, JugadorNombre = "Pablo", JugadorApellido = "Fernández", JugadorUser = "PabloJugador", Lesionado = Lesionado.No, ImageUrl="~/images/8bad9107-56f9-4bf7-972e-5f10b846ea14.png" },
                new Jugador { JugadorId = 8, JugadorSueldo = 1700, JugadorNombre = "Laura", JugadorApellido = "Martínez", JugadorUser = "LauraJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/8cdf84b3-9750-4e51-bfa4-83d721e693c2.png" },
                new Jugador { JugadorId = 9, JugadorSueldo = 2300, JugadorNombre = "Mario", JugadorApellido = "García", JugadorUser = "MarioJugador", Lesionado = Lesionado.No, ImageUrl="~/images/_47c9d792-3d98-44d6-b238-5cd41b80f879.png" },
                new Jugador { JugadorId = 10, JugadorSueldo = 2400, JugadorNombre = "Isabel", JugadorApellido = "López", JugadorUser = "IsabelJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_9e9e8fa6-62a0-4072-9733-34a985cca372.png" },
                new Jugador { JugadorId = 11, JugadorSueldo = 1950, JugadorNombre = "Juan", JugadorApellido = "Hernández", JugadorUser = "JuanJugador", Lesionado = Lesionado.No, ImageUrl="~/images/_e259c736-c326-4505-a76b-3c85a7d212b1.png" },
                new Jugador { JugadorId = 12, JugadorSueldo = 1800, JugadorNombre = "Ana", JugadorApellido = "Gómez", JugadorUser = "AnaJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_cf6e421e-914e-4e1b-b72c-1681a0efa2eb.png" },
                new Jugador { JugadorId = 13, JugadorSueldo = 2200, JugadorNombre = "Diego", JugadorApellido = "Martín", JugadorUser = "DiegoJugador", Lesionado = Lesionado.No, ImageUrl="~/images/_8dce3c44-ae0b-452b-993f-9707833344e6.png" },
                new Jugador { JugadorId = 14, JugadorSueldo = 2100, JugadorNombre = "Eva", JugadorApellido = "Jiménez", JugadorUser = "EvaJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_2b9d4c45-429f-4217-b2da-028950e11336.png" },
                new Jugador { JugadorId = 15, JugadorSueldo = 1900, JugadorNombre = "José", JugadorApellido = "Sánchez", JugadorUser = "JoseJugador", Lesionado = Lesionado.No, ImageUrl="~/images/_1bf715e4-8285-4dde-a2b9-90bad0e56d4d.png" },
                new Jugador { JugadorId = 16, JugadorSueldo = 2000, JugadorNombre = "María", JugadorApellido = "Pérez", JugadorUser = "MariaJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_a3f5eaa5-c392-45aa-a698-33fbac33c2e5.png"},
                new Jugador { JugadorId = 17, JugadorSueldo = 1850, JugadorNombre = "Manuel", JugadorApellido = "Gutiérrez", JugadorUser = "ManuelJugador", Lesionado = Lesionado.No, ImageUrl="~/images/_5c75b6f6-efff-4662-9064-118b2e35dd7d.png" },
                new Jugador { JugadorId = 18, JugadorSueldo = 2050, JugadorNombre = "Carmen", JugadorApellido = "Martínez", JugadorUser = "CarmenJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_89ec388f-428a-4210-87b1-bbd4578b6103.png" },
                new Jugador { JugadorId = 19, JugadorSueldo = 1950, JugadorNombre = "Daniel", JugadorApellido = "González", JugadorUser = "DanielJugador", Lesionado = Lesionado.No , ImageUrl="~/images/_2fc03db0-492e-48d1-9541-4bb0fd806a89.png"},
                new Jugador { JugadorId = 20, JugadorSueldo = 2200, JugadorNombre = "Lorena", JugadorApellido = "Hernández", JugadorUser = "LorenaJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_833d50b0-3d0b-4b92-9303-9a4788fb19c0.png" },
                new Jugador { JugadorId = 21, JugadorSueldo = 2000, JugadorNombre = "Adrián", JugadorApellido = "Fernández", JugadorUser = "AdrianJugador", Lesionado = Lesionado.No, ImageUrl="~/images/_0c1bd7ea-e87d-4fb1-b9e8-3a11f99ad1b2.png" },
                new Jugador { JugadorId = 22, JugadorSueldo = 2100, JugadorNombre = "Marta", JugadorApellido = "Gómez", JugadorUser = "MartaJugador", Lesionado = Lesionado.Si, ImageUrl="~/images/_73db2531-d93e-45f9-8c30-6114e8aceea4.png" }
            };
            modelBuilder.Entity<Jugador>().HasData(jugadores);

            // Sembrar datos de Categorías
            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria { CategoriaId = 1, Niveles = Niveles.Primer_Equipo, JugadorId = 1 },
                new Categoria { CategoriaId = 2, Niveles = Niveles.Juveniles, JugadorId = 2 }
            };
            modelBuilder.Entity<Categoria>().HasData(categorias);

            // Sembrar datos de Cuerpo Técnico
            List<CuerpoTecnico> cuerpoTecnico = new List<CuerpoTecnico>
            {
                 new CuerpoTecnico { CuerpoTecnicoId = 1, CuerpoTecnicoSueldo = 2500, CuerpoTecnicoNombre = "Pedro", CuerpoTecnicoApellido = "Ramírez", JugadorId = 1 },
    new CuerpoTecnico { CuerpoTecnicoId = 2, CuerpoTecnicoSueldo = 2300, CuerpoTecnicoNombre = "Sofía", CuerpoTecnicoApellido = "Fernández", JugadorId = 2 },
    new CuerpoTecnico { CuerpoTecnicoId = 3, CuerpoTecnicoSueldo = 2700, CuerpoTecnicoNombre = "Pablo", CuerpoTecnicoApellido = "Gómez", JugadorId = 3 },
    new CuerpoTecnico { CuerpoTecnicoId = 4, CuerpoTecnicoSueldo = 2800, CuerpoTecnicoNombre = "Elena", CuerpoTecnicoApellido = "Martínez", JugadorId = 4 },
    new CuerpoTecnico { CuerpoTecnicoId = 5, CuerpoTecnicoSueldo = 2900, CuerpoTecnicoNombre = "Alejandro", CuerpoTecnicoApellido = "García", JugadorId = 5 },
    new CuerpoTecnico { CuerpoTecnicoId = 6, CuerpoTecnicoSueldo = 3000, CuerpoTecnicoNombre = "Cristina", CuerpoTecnicoApellido = "Díaz", JugadorId = 6 },
    new CuerpoTecnico { CuerpoTecnicoId = 7, CuerpoTecnicoSueldo = 3100, CuerpoTecnicoNombre = "David", CuerpoTecnicoApellido = "Pérez", JugadorId = 7 }
            };
            modelBuilder.Entity<CuerpoTecnico>().HasData(cuerpoTecnico);

            // Sembrar datos de Productos
            List<Producto> productos = new List<Producto>
{
    new Producto { ProductoId = 1, ProductoNombre = "Balón de fútbol", ProductoPrecio = "20", ImageUrl = "~/images/balon.jpg" },
    new Producto { ProductoId = 2, ProductoNombre = "Conos de entrenamiento", ProductoPrecio = "10", ImageUrl = "~/images/conos.jpg" },
    new Producto { ProductoId = 3, ProductoNombre = "Red de fútbol", ProductoPrecio = "50", ImageUrl = "~/images/red.jpg" },
    new Producto { ProductoId = 4, ProductoNombre = "Botella de agua", ProductoPrecio = "5", ImageUrl = "~/images/botella.jpg" },
    new Producto { ProductoId = 5, ProductoNombre = "Conjunto de pesas", ProductoPrecio = "30", ImageUrl = "~/images/Conjunto_de_pesas.jpg" },
    new Producto { ProductoId = 6, ProductoNombre = "Guantes de portero", ProductoPrecio = "15", ImageUrl = "~/images/guantes.jpg" },
    new Producto { ProductoId = 7, ProductoNombre = "Camiseta deportiva", ProductoPrecio = "25", ImageUrl = "~/images/Camisa5.PNG" },
    new Producto { ProductoId = 8, ProductoNombre = "Zapatillas de fútbol", ProductoPrecio = "40", ImageUrl = "~/images/deportivas.jpg" },
    new Producto { ProductoId = 9, ProductoNombre = "Balón de baloncesto", ProductoPrecio = "30", ImageUrl = "~/images/baloncesto.jpg" },
    new Producto { ProductoId = 10, ProductoNombre = "Camiseta Titular", ProductoPrecio = "50", ImageUrl = "~/images/Camisa1.PNG" },
    new Producto { ProductoId = 11, ProductoNombre = "Camiseta Visitante", ProductoPrecio = "45", ImageUrl = "~/images/Camisa3.PNG" },
    new Producto { ProductoId = 12, ProductoNombre = "Sudadera Retro", ProductoPrecio = "50", ImageUrl = "~/images/retro.jpg" },
    new Producto { ProductoId = 13, ProductoNombre = "Sudadera Visitante", ProductoPrecio = "47", ImageUrl = "~/images/invitado.jpg" },
    new Producto { ProductoId = 14, ProductoNombre = "Camiseta entreno", ProductoPrecio = "35", ImageUrl = "~/images/indumentariaprepartidooscuravisi.jpg" },
    new Producto { ProductoId = 15, ProductoNombre = "Indumentaria Calentamiento", ProductoPrecio = "55", ImageUrl = "~/images/calentar.jpg" },
    new Producto { ProductoId = 16, ProductoNombre = "Cuerda para saltar", ProductoPrecio = "10", ImageUrl = "~/images/camisetaentrenonegra.jpg" }
};
            modelBuilder.Entity<Producto>().HasData(productos);
        }
    }
}
