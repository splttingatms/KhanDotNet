using KhanDotNet.Library.Contracts;
using System;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface ITopicTreeClient : IDisposable
    {
        Task<Topic> GetTopicTreeAsync();
    }
}
