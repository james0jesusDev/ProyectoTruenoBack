namespace ProyectoCore10AbrilBack.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public Niveles Niveles { get; set; }
        public int JugadorId { get; set; }
        public virtual Jugador? Jugador { get; set; }
    }
    public enum Niveles
    {
        Primer_Equipo,
        Juveniles,
        Infantil

    }
}
