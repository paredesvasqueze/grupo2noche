namespace CapaEntidad
{
    public class Investigacion
    {
        public int nIdInvestigacion { get; set; }
        public string cTituloInvestigacion { get; set; }
        public DateTime dAnioInves {  get; set; }   
        public string cInstitucion { get; set; }
        public string cEnlaceAcceso { get; set; }
        public string cResumen {  get; set; }
        public int nIdPublicacion { get; set;}
        public string cIdPublicacion { get; set;}


        public string nTipoPublicacion { get; set; }
        public DateTime dFechaRegistro { get; set; }
        public string cAutor { get; set; }
        public int nIdArea { get; set; }
    }
}
