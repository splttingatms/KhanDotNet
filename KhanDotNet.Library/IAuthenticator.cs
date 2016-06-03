using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IAuthenticator
    {
        Task<string> CreateAuthenticatedRequestPath(string url, CancellationToken cancellationToken);
    }
}
