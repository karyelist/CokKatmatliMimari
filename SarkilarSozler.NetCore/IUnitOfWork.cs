using SarkilarSozler.NetCore.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SarkilarSozler.NetCore
{
    public interface IUnitOfWork : IDisposable
    {
        ISarkiRepository Sarkilar { get; }
        ISanatciRepository Sanatcilar { get; }
        Task<int> CommitAsync();
    }
}