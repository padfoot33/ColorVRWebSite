using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Models;

namespace ColorVRWebSite.Data.Interfaces
{
    public interface IPlayGroundRepository
    {
        IEnumerable<PlayGrounds> playGrounds { get; }
        IEnumerable<PlayGrounds> PreferredPlayGrounds { get; }
        PlayGrounds GetPlayerGroundById(int PGId);
    }
}
