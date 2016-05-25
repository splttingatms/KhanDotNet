using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Tests.Data
{
    public static class BadgeTestData
    {
        #region categories

        public const string SampleBadgeCategoriesJson = "[{\"category\": 0, \"icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-small.png\", \"type_label\": \"Meteorite Badges\", \"email_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-70x70.png\", \"large_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite.png\", \"compact_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-60x60.png\", \"translated_description\": \"Meteorite badges are common and easy to earn when just getting started.\", \"chart_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-small-chart.png\", \"medium_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-medium.png\", \"CATEGORIES\": [0, 1, 2, 3, 4, 5], \"description\": \"Meteorite badges are common and easy to earn when just getting started.\"}, {\"category\": 1, \"icon_src\": \"https://fastly.kastatic.org/images/badges/moon-small.png\", \"type_label\": \"Moon Badges\", \"email_icon_src\": \"https://fastly.kastatic.org/images/badges/moon-70x70.png\", \"large_icon_src\": \"https://fastly.kastatic.org/images/badges/moon.png\", \"compact_icon_src\": \"https://fastly.kastatic.org/images/badges/moon-60x60.png\", \"translated_description\": \"Moon badges are uncommon and represent an investment in learning.\", \"chart_icon_src\": \"https://fastly.kastatic.org/images/badges/moon-small-chart.png\", \"medium_icon_src\": \"https://fastly.kastatic.org/images/badges/moon-medium.png\", \"CATEGORIES\": [0, 1, 2, 3, 4, 5], \"description\": \"Moon badges are uncommon and represent an investment in learning.\"}]";

        public const string SampleBadgeCategoryJson = "[{\"category\": 0,\"icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-small.png\",\"type_label\": \"Meteorite Badges\",\"email_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-70x70.png\",\"large_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite.png\",\"compact_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-60x60.png\",\"translated_description\": \"Meteorite badges are common and easy to earn when just getting started.\",\"chart_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-small-chart.png\",\"medium_icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite-medium.png\",\"CATEGORIES\": [0, 1, 2, 3, 4, 5],\"description\": \"Meteorite badges are common and easy to earn when just getting started.\"}]";

        public static readonly BadgeCategory MeteoriteBadgeCategory = new BadgeCategory()
        {
            Category = Category.Meteorite,
            IconSrc = "https://fastly.kastatic.org/images/badges/meteorite-small.png",
            TypeLabel = "Meteorite Badges",
            EmailIconSrc = "https://fastly.kastatic.org/images/badges/meteorite-70x70.png",
            LargeIconSrc = "https://fastly.kastatic.org/images/badges/meteorite.png",
            ComapctIconSrc = "https://fastly.kastatic.org/images/badges/meteorite-60x60.png",
            TranslatedDescription = "Meteorite badges are common and easy to earn when just getting started.",
            ChartIconSrc = "https://fastly.kastatic.org/images/badges/meteorite-small-chart.png",
            MediumIconSrc = "https://fastly.kastatic.org/images/badges/meteorite-medium.png",
            Categories = new List<Category>() { Category.Meteorite, Category.Moon, Category.Earth, Category.Sun, Category.BlackHole, Category.ChallengePatch },
            Description = "Meteorite badges are common and easy to earn when just getting started."
        };

        public static readonly BadgeCategory MoonBadgeCategory = new BadgeCategory()
        {
            Category = Category.Moon,
            IconSrc = "https://fastly.kastatic.org/images/badges/moon-small.png",
            TypeLabel = "Moon Badges",
            EmailIconSrc = "https://fastly.kastatic.org/images/badges/moon-70x70.png",
            LargeIconSrc = "https://fastly.kastatic.org/images/badges/moon.png",
            ComapctIconSrc = "https://fastly.kastatic.org/images/badges/moon-60x60.png",
            TranslatedDescription = "Moon badges are uncommon and represent an investment in learning.",
            ChartIconSrc = "https://fastly.kastatic.org/images/badges/moon-small-chart.png",
            MediumIconSrc = "https://fastly.kastatic.org/images/badges/moon-medium.png",
            Categories = new List<Category>() { Category.Meteorite, Category.Moon, Category.Earth, Category.Sun, Category.BlackHole, Category.ChallengePatch },
            Description = "Moon badges are uncommon and represent an investment in learning."
        };

        public static readonly List<BadgeCategory> SampleBadgeCategories = new List<BadgeCategory>()
        {
            MeteoriteBadgeCategory,
            MoonBadgeCategory
        };

        #endregion

        #region badges

        public static readonly Badge FactChecker = new Badge()
        {
            IconSource = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"),
            HideContext = false,
            Description = "Fact Checker",
            RelativeUrl = new Uri("/badges/fact-checker", UriKind.Relative),
            Icons = new Icons()
            {
                Small = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"),
                Compact = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-60x60.png"),
                Large = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-512x512.png"),
                Email = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-70x70.png")
            },
            AbsoluteUrl = new Uri("http://www.khanacademy.org/badges/fact-checker"),
            UserBadges = null,
            DescriptionExtendedTranslatedSafe = "Have a clarification officially accepted",
            DescriptionTranslated = "Fact Checker",
            IsOwned = false,
            Category = 1,
            Points = 0,
            IsRetired = false,
            DescriptionExtendedSafe = "Have a clarification officially accepted",
            Slug = "fact-checker",
            Name = "acceptclarificationbadge"
        };

        public static readonly Badge ActOneSceneOne = new Badge()
        {
            IconSource = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"),
            HideContext = false,
            Description = "Act I Scene I",
            RelativeUrl = new Uri("/badges/act-i-scene-i", UriKind.Relative),
            Icons = new Icons()
            {
                Small = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"),
                Compact = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-60x60.png"),
                Large = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-512x512.png"),
                Email = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-70x70.png")
            },
            AbsoluteUrl = new Uri("http://www.khanacademy.org/badges/act-i-scene-i"),
            UserBadges = null,
            DescriptionExtendedTranslatedSafe = "Watch 20 minutes of video",
            DescriptionTranslated = "Act I Scene I",
            IsOwned = false,
            Category = 0,
            Points = 0,
            IsRetired = false,
            DescriptionExtendedSafe = "Watch 20 minutes of video",
            Slug = "act-i-scene-i",
            Name = "actonesceneonebadge"
        };

        public static readonly List<Badge> SampleBadges = new List<Badge>()
                {
                    BadgeTestData.FactChecker,
                    BadgeTestData.ActOneSceneOne
                };

        public const string SampleBadgesJson = "[{\"icon_src\": \"https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png\",\"hide_context\": false,\"description\": \"Fact Checker\",\"relative_url\": \"/badges/fact-checker\",\"icons\": {\"small\": \"https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png\",\"compact\": \"https://fastly.kastatic.org/images/badges/moon/fact-checker-60x60.png\",\"large\": \"https://fastly.kastatic.org/images/badges/moon/fact-checker-512x512.png\",\"email\": \"https://fastly.kastatic.org/images/badges/moon/fact-checker-70x70.png\"},\"absolute_url\": \"http://www.khanacademy.org/badges/fact-checker\",\"user_badges\": null,\"translated_safe_extended_description\": \"Have a clarification officially accepted\",\"translated_description\": \"Fact Checker\",\"is_owned\": false,\"badge_category\": 1,\"points\": 0,\"is_retired\": false,\"safe_extended_description\": \"Have a clarification officially accepted\",\"slug\": \"fact-checker\",\"name\": \"acceptclarificationbadge\"},{\"icon_src\": \"https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png\",\"hide_context\": false,\"description\": \"Act I Scene I\",\"relative_url\": \"/badges/act-i-scene-i\",\"icons\": {\"small\": \"https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png\",\"compact\": \"https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-60x60.png\",\"large\": \"https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-512x512.png\",\"email\": \"https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-70x70.png\"},\"absolute_url\": \"http://www.khanacademy.org/badges/act-i-scene-i\",\"user_badges\": null,\"translated_safe_extended_description\": \"Watch 20 minutes of video\",\"translated_description\": \"Act I Scene I\",\"is_owned\": false,\"badge_category\": 0,\"points\": 0,\"is_retired\": false,\"safe_extended_description\": \"Watch 20 minutes of video\",\"slug\": \"act-i-scene-i\",\"name\": \"actonesceneonebadge\"}]";

        #endregion
    }
}
