using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IBadgeClient : IDisposable
    {
        Task<List<Badge>> GetBadges();
    }
}
