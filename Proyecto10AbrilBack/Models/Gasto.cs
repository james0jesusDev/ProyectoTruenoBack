namespace ProyectoCore10AbrilBack.Models
{
    public class Gasto
    {
        public int GastoId { get; set; }
        public string? GastoNombre { get; set; }
        public int AbonadoId { get; set; }
        public virtual Abonado? Abonado { get; set; }
        public virtual Producto? Producto { get; set; }
        public virtual CuerpoTecnico? CuerpoTecnico { get; set; }
    }
}
