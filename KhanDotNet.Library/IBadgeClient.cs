using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IBadgeClient : IDisposable
    {
        Task<List<Badge>> GetBadgesAsync();
        Task<List<Badge>> GetBadgesAsync(CancellationToken cancellationToken);

        Task<List<BadgeCategory>> GetBadgeCategoriesAsync();
        Task<List<BadgeCategory>> GetBadgeCategoriesAsync(CancellationToken cancellationToken);

        Task<BadgeCategory> GetBadgeCategoryAsync(Category category);
        Task<BadgeCategory> GetBadgeCategoryAsync(Category category, CancellationToken cancellationToken);
    }
}
