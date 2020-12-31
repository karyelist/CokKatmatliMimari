using SarkilarSozler.NetCore;
using SarkilarSozler.NetCore.Repository;
using SarkilarSozler.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
 

namespace SarkilarSozler.Data
{

  public  class UnitOfWork : IUnitOfWork
    {
        private readonly SarkiSozlerDbContext _context;
        private SarkiRepository _sarkiRepository;
        private SanatciRepository _sanatciRepository;

        public UnitOfWork(SarkiSozlerDbContext context)
        {
            _context = context;
        }

        public ISarkiRepository Sarkilar => _sarkiRepository = _sarkiRepository ?? new SarkiRepository(_context);

        public ISanatciRepository Sanatcilar => _sanatciRepository = _sanatciRepository ?? new SanatciRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
           
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
