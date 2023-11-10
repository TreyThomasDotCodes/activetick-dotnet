using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public record SnapshotResponseRow
    {
        [JsonPropertyName("s")]
        public string Symbol { get; init; }

        [JsonPropertyName("st")]
        public string Status { get; init; }

        public List<SnapshotResponseRowData> Data { get; init; }
    }
}
