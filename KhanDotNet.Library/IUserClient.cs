using KhanDotNet.Library.Contracts;
using System;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IUserClient : IDisposable
    {
        Task<User> GetUserAsync();
    }
}
