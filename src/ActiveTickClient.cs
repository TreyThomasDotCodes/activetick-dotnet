using RestSharp;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public class ActiveTickClient : IActiveTickClient, IDisposable
    {
        private readonly RestClient _client;

        public ActiveTickClient(string baseUrl, string username, string password, string apiKey)
        {
            var options = new RestClientOptions()
            {
                Authenticator = new ActiveTickAuthenticator(baseUrl, username, password, apiKey),
                BaseUrl = new Uri(baseUrl)
            };

            _client = new RestClient(options);
            _client.AddDefaultHeader("Accept-Encoding", "gzip,deflate");
        }

        public async Task<Snapshot> GetSnapshotAsync(string symbol)
        {
            if (symbol.Contains(','))
                throw new NotImplementedException("Multiple symbol snapshot not yet implemented");

            var response = await _client.GetJsonAsync<SnapshotResponse>($"snapshot.json", new { symbols = symbol, columns = "b,bsz,a,asz,l,lsz,v,tc" });
            var snapshot = new Snapshot(response.Rows.Single());
            return snapshot;
        }

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}