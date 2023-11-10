using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public record SnapshotResponse
    {
        public string Type { get; init; }
        public string Status { get; init; }
        public List<SnapshotResponseRow> Rows { get; init; }
    }
}
