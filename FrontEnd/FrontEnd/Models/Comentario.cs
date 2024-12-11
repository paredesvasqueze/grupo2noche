namespace FrontEnd.Models
{
    public class Comentario
    {
        public DateTime dFechaComentario { get; set; }
        public int nIdPublicacion { get; set; }
        public string cIdPublicacion { get; set; }
        public int nIdUsuario { get; set; }
        public string cComentario { get; set; }
    }
}
