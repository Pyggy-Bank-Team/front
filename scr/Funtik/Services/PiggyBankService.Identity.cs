using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Funtik.Interfaces;
using Funtik.Models.Services;
using Funtik.Models.Services.Responses;
using Newtonsoft.Json;

namespace Funtik.Services
{
    public partial class PiggyBankService : IIdentityService
    {
        private const string IdentityServer = @"http://dtrest1-001-site1.itempurl.com";
        private const string ClientSecret = "secret";
        private const string Scope = "api1";

        public async Task<bool> RegistrationUser(UserModel user)
        {
            using (_client)
            {
                var response = await _client.PostAsJsonAsync($"{IdentityServer}/users", user);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<TokenResponse> GetToken(UserModel user)
        {
            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_id", "client"),
                new KeyValuePair<string, string>("client_secret", ClientSecret),
                new KeyValuePair<string, string>("scope", Scope),
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", user.UserName),
                new KeyValuePair<string, string>("password", user.Password)
            };

            using (_client)
            {
                var content = new FormUrlEncodedContent(body);
                var response = await _client.PostAsync($"{IdentityServer}/connect/token", content);

                return !response.IsSuccessStatusCode 
                    ? null 
                    : JsonConvert.DeserializeObject<TokenResponse>(await response.Content.ReadAsStringAsync());
            }
        }
    }
}