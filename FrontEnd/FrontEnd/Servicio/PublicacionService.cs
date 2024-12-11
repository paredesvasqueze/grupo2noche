using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class PublicacionService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public PublicacionService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Publicacion>> GetPublicacionsAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Publicacion/ObtenerPublicacionTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Publicacion>>();
        }

        public async Task<bool> CreatePublicacionAsync(Publicacion Publicacion, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Publicacion/InsertarPublicacion", Publicacion);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdatePublicacionAsync(Publicacion Publicacion, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Publicacion/ActualizarPublicacion", Publicacion);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePublicacionAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Publicacion/EliminarPublicacion/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

