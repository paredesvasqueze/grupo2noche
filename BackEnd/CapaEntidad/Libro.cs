namespace CapaEntidad
{
    public class Libro
    {
        public int nIdLibro {  get; set; }
        public string cTituloLibro { get; set;}
        public string cEditorial { get; set; }
        public int nPaginas { get; set; }
        public string cIdioma { get; set; }
        public int nIdGenero {  get; set; }
        public int nIdPublicacion { get; set; }
        public string cIdPublicacion { get; set; }

        public string nTipoPublicacion { get; set; }
        public DateTime dFechaRegistro { get; set; }
        public string cAutor { get; set; }
        public int nIdArea { get; set; }

    }
}
