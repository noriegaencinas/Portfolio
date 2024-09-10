using WebApplication2.Models;

namespace WebApplication2.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto
            {
                Titulo = "Gestor de taller",
                Descripcion = "Sistema para gestionar las tareas de un taller mecánico",
                Link = "https://apps5.handle.mx/",
                ImageURL = "/imagenes/autorefrigeraciones.png"
            },
            new Proyecto
            {
                Titulo = "Visualizador de ajedrez",
                Descripcion = "Sistema para visualizar partidas de ajedrez",
                Link = "https://blackbow.mx/",
                ImageURL = "/imagenes/visualizador.png"
            },
            new Proyecto
            {
                Titulo = "Pong",
                Descripcion = "Clásico juego de pong",
                Link = "https://amazon.com",
                ImageURL = "/imagenes/pong.png"
            },
            new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Administración de servidor",
                Link = "https://nytimes.com",
                ImageURL = "/imagenes/nyt.png"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Desarrollador Back-end",
                Link = "https://steam.com",
                ImageURL = "/imagenes/steam.png"
            },
            };
        }
    }
}
