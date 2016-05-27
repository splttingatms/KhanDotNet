using KhanDotNet.Library.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface ITopicTreeClient : IDisposable
    {
        Task<Topic> GetTopicTreeAsync();
        Task<Topic> GetTopicTreeAsync(CancellationToken cancellationToken);
    }
}
