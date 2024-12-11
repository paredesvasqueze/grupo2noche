namespace CapaEntidad
{
    public class Articulo
    {
        public int nIdArticulo { get; set; }
        public string cTituloArticulo { get; set; }
        public DateTime dFechaArticulo { get; set; }
        public string cTexto { get; set; }
        public string nVolumen { get; set; }
        public int nIdPublicacion { get; set; }
        public string cIdPublicacion { get;set; }

        public string nTipoPublicacion { get; set; }
        public DateTime dFechaRegistro { get; set; }
        public string cAutor { get; set; }
        public int nIdArea { get; set; }
    }
}
