using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class AutorService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public AutorService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Autor>> GetAutorsAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Autor/ObtenerAutorTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Autor>>();
        }

        public async Task<bool> CreateAutorAsync(Autor Autor, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Autor/InsertarAutor", Autor);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAutorAsync(Autor Autor, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Autor/ActualizarAutor", Autor);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAutorAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Autor/EliminarAutor/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

