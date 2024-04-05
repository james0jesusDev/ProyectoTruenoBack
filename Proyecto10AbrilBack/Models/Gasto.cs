namespace ProyectoCore10AbrilBack.Models
{
    public class Gasto
    {
        public int GastoId { get; set; }
        public string? GastoNombre { get; set; }
        public int Cantidad { get; set; }

        public Dinero? Dinero { get; set; }

       


    }

    public enum Dinero
    {
        Beneficio,
        Gasto

    }
}
