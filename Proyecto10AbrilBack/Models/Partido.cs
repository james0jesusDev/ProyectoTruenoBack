namespace Proyecto10AbrilBack.Models
{
    public class Partido
    {

        public int ID { get; set; }
        public string? Fecha { get; set; }
   
        public string? EquipoLocal { get; set; }
        public string? EquipoVisitante { get; set; }
        public string? Hora { get; set; }
        public string? Estadio { get; set; }
        public string? LogoLocal { get; set; }
        public string? LogoVisitante { get; set; }

        //public override string ToString()
        //{
        //    return $"Partido: {EquipoLocal} vs {EquipoVisitante}, {Fecha}, {Hora}, {Estadio}";
        //}
    }
}
