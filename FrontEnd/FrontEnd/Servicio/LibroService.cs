using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class LibroService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public LibroService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Libro>> GetLibrosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Libro/ObtenerLibroTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Libro>>();
        }

        public async Task<bool> CreateLibroAsync(Libro Libro, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Libro/InsertarLibro", Libro);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateLibroAsync(Libro Libro, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Libro/ActualizarLibro", Libro);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteLibroAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Libro/EliminarLibro/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}
