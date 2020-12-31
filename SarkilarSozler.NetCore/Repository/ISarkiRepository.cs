
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SarkilarSozler.NetCore.Models;
using SarkilarSozler.NetCore.Repository;

namespace SarkilarSozler.NetCore.Repository
{
    public interface ISarkiRepository : IRepository<Sarkilar>
    {
        Task<IEnumerable<Sarkilar>> GetAllWithArtistAsync();
        Task<Sarkilar> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Sarkilar>> GetAllWithArtistByArtistIdAsync(int SanatciId);
    }
}