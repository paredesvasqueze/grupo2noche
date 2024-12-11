using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class ArticuloService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public ArticuloService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Articulo>> GetArticulosAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Articulo/ObtenerArticuloTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Articulo>>();
        }

        public async Task<bool> CreateArticuloAsync(Articulo Articulo, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Articulo/InsertarArticulo", Articulo);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateArticuloAsync(Articulo Articulo, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Articulo/ActualizarArticulo", Articulo);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteArticuloAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Articulo/EliminarArticulo/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

