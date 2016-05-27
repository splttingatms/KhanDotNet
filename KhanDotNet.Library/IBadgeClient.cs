using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IBadgeClient : IDisposable
    {
        Task<List<Badge>> GetBadgesAsync();

        Task<List<BadgeCategory>> GetBadgeCategoriesAsync();

        Task<BadgeCategory> GetBadgeCategoryAsync(Category meteorite);
    }
}
