using KhanDotNet.Library.Contract;
using System;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IUserClient : IDisposable
    {
        Task<User> GetUserAsync();
    }
}
