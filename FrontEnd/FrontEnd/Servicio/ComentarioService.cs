using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class ComentarioService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public ComentarioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Comentario>> GetComentariosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Comentario/ObtenerComentarioTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Comentario>>();
        }

        public async Task<bool> CreateComentarioAsync(Comentario Comentario, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Comentario/InsertarComentario", Comentario);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateComentarioAsync(Comentario Comentario, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Comentario/ActualizarComentario", Comentario);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteComentarioAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Comentario/EliminarComentario/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

