using FrontEnd.Models;

namespace FrontEnd.Servicio
{
    public class InvestigacionService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        string _baseURL = string.Empty;

        public InvestigacionService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseURL = _configuration["UrlBaseAPIs"];
            _httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<IEnumerable<Investigacion>> GetInvestigacionsAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync("Investigacion/ObtenerInvestigacionTodos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Investigacion>>();
        }

        public async Task<bool> CreateInvestigacionAsync(Investigacion Investigacion, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsJsonAsync("Investigacion/InsertarInvestigacion", Investigacion);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateInvestigacionAsync(Investigacion Investigacion, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PutAsJsonAsync($"Investigacion/ActualizarInvestigacion", Investigacion);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteInvestigacionAsync(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.DeleteAsync($"Investigacion/EliminarInvestigacion/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}

