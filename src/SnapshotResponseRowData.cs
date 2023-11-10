using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public record SnapshotResponseRowData
    {
        [JsonPropertyName("c")]
        public string Column { get; init; }

        [JsonPropertyName("s")]
        public string Status { get; init; }

        [JsonPropertyName("v")]
        public string Value { get; init; }
    }
}
