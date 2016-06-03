using System;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    // Followed "static initialization" singleton pattern from https://msdn.microsoft.com/en-us/library/ff650316.aspx
    public sealed class NoopAuthenticator : IAuthenticator
    {
        private static readonly IAuthenticator instance = new NoopAuthenticator();

        private NoopAuthenticator() { }

        public static IAuthenticator Instance
        {
            get
            {
                return instance;
            }
        }

        public Task<string> CreateAuthenticatedRequestPath(string url, CancellationToken cancellationToken)
        {
            throw new InvalidOperationException("Cannot authenticate using no-op authenticator");
        }
    }
}
