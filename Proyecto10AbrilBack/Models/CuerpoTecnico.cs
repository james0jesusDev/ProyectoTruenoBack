namespace ProyectoCore10AbrilBack.Models
{
    public class CuerpoTecnico
    {
        public int CuerpoTecnicoId { get; set; }
        public int CuerpoTecnicoSueldo { get; set; }
        public string? CuerpoTecnicoNombre { get; set; }
        public string? CuerpoTecnicoApellido { get; set; }
        public int JugadorId { get; set; }
        public virtual Jugador? Jugador { get; set; }
    }
}
