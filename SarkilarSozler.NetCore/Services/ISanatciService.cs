using SarkilarSozler.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace available.Core.Services
{
    public interface IMusicService
    {
        Task<IEnumerable<Sarkilar>> GetAllWithArtist();
        Task<Sarkilar> GetMusicById(int id);
        Task<IEnumerable<Sarkilar>> GetMusicsByArtistId(int sanatciId);
        Task<Sarkilar> CreateMusic(Sarkilar yeniSarki);
        Task UpdateMusic(Sarkilar SarkiGuncellendi, Sarkilar sarki);
        Task DeleteMusic(Sarkilar sarki);
    }
}