namespace ProyectoCore10AbrilBack.Models
{
    public class Jugador
    {
        public int JugadorId { get; set; }
        public int JugadorSueldo { get; set; }
        public string? JugadorNombre { get; set; }
        public string? JugadorApellido { get; set; }
        public string? JugadorUser { get; set; }
        public string? ImageUrl { get; set; }
        public Lesionado Lesionado { get; set; }
    }
    public enum Lesionado
    {
        Si,
        No,
        En_Pruebas
    }
}
