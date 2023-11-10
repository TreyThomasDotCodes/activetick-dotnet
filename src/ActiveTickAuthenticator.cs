using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public class ActiveTickAuthenticator : AuthenticatorBase
    {
        private readonly string _baseUrl;
        private readonly string _username;
        private readonly string _password;
        private readonly string _apiKey;

        public ActiveTickAuthenticator(string baseUrl, string username, string password, string apiKey) : base("")
        {
            _baseUrl = baseUrl;
            _username = username;
            _password = password;
            _apiKey = apiKey;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            Token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;
            return new QueryParameter("sessionid", Token);
        }

        private async Task<string> GetToken()
        {
            var options = new RestClientOptions(_baseUrl);
            using var client = new RestClient(options);

            var request = new RestRequest("authorize.json")
                .AddParameter("username", _username)
                .AddParameter("password", _password)
                .AddParameter("apikey", _apiKey);
            var response = await client.GetAsync<TokenResponse>(request);
            return $"{response!.Token}";
        }
    }
}
