using KhanDotNet.Library.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IUserClient : IDisposable
    {
        Task<User> GetUserAsync();
        Task<User> GetUserAsync(CancellationToken cancellationToken);
    }
}
