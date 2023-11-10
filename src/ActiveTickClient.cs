using RestSharp;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public class ActiveTickClient : IActiveTickClient, IDisposable
    {
        private readonly RestClient _client;

        public ActiveTickClient(string username, string password, string apiKey)
        {
            var options = new RestClientOptions("https://api.activetick.com")
            {
                Authenticator = new ActiveTickAuthenticator("https://api.activetick.com", username, password, apiKey)
            };

            _client = new RestClient(options);
        }

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}