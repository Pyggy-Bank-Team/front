using System.Net.Http;

namespace Funtik.Services
{
    public partial class PiggyBankService
    {
        private readonly HttpClient _client;

        public PiggyBankService(HttpClient client)
            => _client = client;
    }
}