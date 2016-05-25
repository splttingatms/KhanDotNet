using KhanDotNet.Library.Contract;
using System;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface ITopicClient : IDisposable
    {
        Task<Topic> GetTopicAsync(string name);
    }
}
