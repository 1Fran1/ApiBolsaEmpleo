namespace ApiBolsaEmpleo.Model
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }

        public List<Educacion> Educacion { get; set; }
        public List<Candidato_Habilidad> Habilidad { get; set; }
    }
}


