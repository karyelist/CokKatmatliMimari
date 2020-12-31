
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SarkilarSozler.Core.Models;
using SarkilarSozler.Core.Repository;

namespace SarkilarSozler.Core.Repository
{
    public interface ISarkiRepository : IRepository<Sarkilar>
    {
        Task<IEnumerable<Sarkilar>> GetAllWithArtistAsync();
        Task<Sarkilar> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Sarkilar>> GetAllWithArtistByArtistIdAsync(int SanatciId);
    }
}