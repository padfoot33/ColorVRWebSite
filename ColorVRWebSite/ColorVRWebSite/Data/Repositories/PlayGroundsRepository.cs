using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using ColorVRWebSite.Data.Interfaces;
using ColorVRWebSite.Data.Models;
using ColorVRWebSite.Data;

namespace ColorVRWebSite.Data.Repositories
{
    public class PlayGroundsRepository : IPlayGroundRepository
    {
        private readonly AppDbContext _appDbContext;

        public PlayGroundsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
    }

        public IEnumerable<PlayGrounds> playGrounds => _appDbContext.playGrounds.Include(c => c.category);

        public IEnumerable<PlayGrounds> PreferredPlayGrounds => _appDbContext.playGrounds
            .Where(p => p.isPreferedPG).Include(c => c.category);

        public PlayGrounds GetPlayerGroundById(int PGId) => _appDbContext.playGrounds
            .FirstOrDefault(p=>p.PGId == PGId);
    }
}
