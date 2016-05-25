using KhanDotNet.Library.Contract;
using System;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface ITopicTreeClient : IDisposable
    {
        Task<Topic> GetTopicTreeAsync();
    }
}
