using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class PublicacionAutorService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public PublicacionAutorService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<PublicacionAutor>> GetPublicacionAutorsAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("PublicacionAutor/ObtenerPublicacionAutorTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<PublicacionAutor>>();
        }

        public async Task<bool> CreatePublicacionAutorAsync(PublicacionAutor PublicacionAutor, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("PublicacionAutor/InsertarPublicacionAutor", PublicacionAutor);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePublicacionAutorAsync(PublicacionAutor PublicacionAutor, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"PublicacionAutor/ActualizarPublicacionAutor", PublicacionAutor);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePublicacionAutorAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"PublicacionAutor/EliminarPublicacionAutor/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

