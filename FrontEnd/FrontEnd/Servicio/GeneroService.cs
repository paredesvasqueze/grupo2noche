using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class GeneroService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public GeneroService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Genero>> GetGenerosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Genero/ObtenerGeneroTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Genero>>();
        }

        public async Task<bool> CreateGeneroAsync(Genero Genero, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Genero/InsertarGenero", Genero);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateGeneroAsync(Genero Genero, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Genero/ActualizarGenero", Genero);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteGeneroAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Genero/EliminarGenero/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

