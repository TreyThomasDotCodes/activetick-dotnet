using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreyThomasCodes.ActiveTickDotNet
{
    public interface IActiveTickClient
    {
        Task<Snapshot> GetSnapshotAsync(string symbol);
    }
}
