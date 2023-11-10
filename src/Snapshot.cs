using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public record Snapshot
    {
        public string Symbol { get; init; }
        public float Bid { get; init; }
        public uint BidSize { get; init; }
        public float Ask { get; init; }
        public uint AskSize { get; init; }
        public float Last { get;init; }
        public uint LastSize { get; init; }
        public uint Volume { get; init; }
        public uint TradeCount { get; init; }

        public Snapshot(SnapshotResponseRow row)
        {
            var data = row.Data.ToImmutableDictionary(x => x.Column, y => y.Value);

            Ask = float.Parse(data["a"]);
            AskSize = uint.Parse(data["asz"]);
            Bid = float.Parse(data["b"]);
            BidSize = uint.Parse(data["bsz"]);
            Last = float.Parse(data["l"]);
            LastSize = uint.Parse(data["lsz"]);
            Symbol = row.Symbol;
            TradeCount = uint.Parse(data["tc"]);
            Volume = uint.Parse(data["v"]);
        }

        public Snapshot()
        {
            
        }
    }
}
