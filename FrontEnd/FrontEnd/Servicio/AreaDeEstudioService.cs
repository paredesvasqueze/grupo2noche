using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class AreaDeEstudioService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public AreaDeEstudioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<AreaDeEstudio>> GetAreaDeEstudiosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("AreaDeEstudio/ObtenerAreaDeEstudioTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<AreaDeEstudio>>();
        }

        public async Task<bool> CreateAreaDeEstudioAsync(AreaDeEstudio AreaDeEstudio, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("AreaDeEstudio/InsertarAreaDeEstudio", AreaDeEstudio);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAreaDeEstudioAsync(AreaDeEstudio AreaDeEstudio, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"AreaDeEstudio/ActualizarAreaDeEstudio", AreaDeEstudio);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAreaDeEstudioAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"AreaDeEstudio/EliminarAreaDeEstudio/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}
