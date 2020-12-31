using SarkilarSozler.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SarkilarSozler.Core.Services
{
    public interface ISanatciService
    {
        Task<IEnumerable<Sanatci>> GetAllArtists();
        Task<Sanatci> GetArtistById(int id);
        Task<Sanatci> CreateArtist(Sanatci YeniSanatci);
        Task UpdateArtist(Sanatci SanatciGuncelenmis, Sanatci sanatci);
        Task DeleteArtist(Sanatci sanatci);
    }
}