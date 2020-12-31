using SarkilarSozler.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarket.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ISarkiRepository Sarkilar { get; }
        ISanatciRepository Sanatcilar { get; }
        Task<int> CommitAsync();
    }
}