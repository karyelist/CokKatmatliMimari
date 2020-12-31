using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SarkilarSozler.NetCore.Models;
using SarkilarSozler.NetCore.Repository;

namespace SarkilarSozler.NetCore.Repository
{
    public interface ISanatciRepository : IRepository<Sanatci>
    {
        Task<IEnumerable<Sanatci>> GetAllWithMusicsAsync();
        Task<Sanatci> GetWithMusicsByIdAsync(int id);
    }
}