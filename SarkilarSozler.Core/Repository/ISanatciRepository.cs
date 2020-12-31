using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SarkilarSozler.Core.Models;
using SarkilarSozler.Core.Repository;

namespace SarkilarSozler.Core.Repository
{
    public interface ISanatciRepository : IRepository<Sanatci>
    {
        Task<IEnumerable<Sanatci>> GetAllWithMusicsAsync();
        Task<Sanatci> GetWithMusicsByIdAsync(int id);
    }
}