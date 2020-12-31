
using Microsoft.EntityFrameworkCore;
using SarkilarSozler.Data.Repositories;
using SarkilarSozler.NetCore.Models;
using SarkilarSozler.NetCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SarkilarSozler.Data.Repositories
{
   public class SarkiRepository : Repository<Sarkilar>, ISarkiRepository
    {
        public SarkiRepository(SarkiSozlerDbContext context)
               : base(context)
        { }
       
     

        public async Task<IEnumerable<Sarkilar>> GetAllWithArtistAsync()
        {
            return await SarkiSozlerDbContext.Sarkilar
                   .Include(m => m.Sanatcilar)
                   .ToListAsync();
        }

        public async Task<IEnumerable<Sarkilar>> GetAllWithArtistByArtistIdAsync(int SanatciId)
        {
            return await SarkiSozlerDbContext.Sarkilar
                 .Include(m => m.Sanatcilar)
                 .Where(m => m.SanatciId == SanatciId)
                 .ToListAsync();
        }

        public ValueTask<Sarkilar> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Sarkilar> GetWithArtistByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        private SarkiSozlerDbContext SarkiSozlerDbContext
        {
            get { return Context as SarkiSozlerDbContext; }
        }
    }
}
