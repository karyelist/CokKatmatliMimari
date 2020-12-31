using Microsoft.EntityFrameworkCore;
using SarkilarSozler.NetCore.Models;
using SarkilarSozler.NetCore.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SarkilarSozler.Data.Repositories
{
    class SanatciRepository : Repository<Sanatci>, ISanatciRepository
    {
       // protected readonly SarkiSozlerDbContext Context;

        public SanatciRepository(SarkiSozlerDbContext context)
               : base(context)
        {
            //Context = context;

        }
        public async  Task<IEnumerable<Sanatci>> GetAllWithMusicsAsync()
        {
            return await SarkiSozlerDbContext.Sanatcilar
                      .Include(a => a.Sarkilar)
                      .ToListAsync();
        }

        public Task<Sanatci> GetWithMusicsByIdAsync(int id)
        {
            return SarkiSozlerDbContext.Sanatcilar
                .Include(a => a.Sarkilar)
                .SingleOrDefaultAsync(a => a.Id == id);
        }


        private SarkiSozlerDbContext SarkiSozlerDbContext
        {
            get { return Context as SarkiSozlerDbContext; }
        }
    }
}
