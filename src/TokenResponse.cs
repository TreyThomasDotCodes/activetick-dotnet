using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    internal record TokenResponse
    {
        [JsonPropertyName("type")]
        public string ResponseType { get; init; }

        [JsonPropertyName("status")]
        public string Status { get; init; }

        [JsonPropertyName("sessionid")]
        public string Token { get; init; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; }

        [JsonPropertyName("is_realtime")]
        public string IsRealtime { get; init;}
    }
}
