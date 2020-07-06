using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Funtik.Models.Services;

namespace Funtik.Services
{
    public class PiggyBankService
    {
        private const string IndentityServer = @"http://dtrest1-001-site1.itempurl.com";
        private readonly IHttpClientFactory _clientFactory;

        public PiggyBankService(IHttpClientFactory clientFactory)
            => _clientFactory = clientFactory;

        public async Task<bool> CreateUserAsync(UserModel model)
        {
            using var client = _clientFactory.CreateClient();
            var response = await client.PostAsync($"{IndentityServer}/users", new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }

        public async Task<string> GetAccessToken(UserModel model)
        {
            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_id", "client"),
                new KeyValuePair<string, string>("client_secret", "secret"),
                new KeyValuePair<string, string>("scope", "api1"),
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", model.UserName),
                new KeyValuePair<string, string>("password", model.Password)
            };

            using var httClient = _clientFactory.CreateClient();
            var content = new FormUrlEncodedContent(body);
            var response = await httClient.PostAsync($"{IndentityServer}/connect/token", content);

            dynamic result = await response.Content.ReadAsStringAsync();
            return string.Empty;
        }
    }
}
