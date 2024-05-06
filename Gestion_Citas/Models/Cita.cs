namespace Gestion_Citas.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Servicio Servicio { get; set; }
        public DateTime FechaHora { get; set; }

    }

}
