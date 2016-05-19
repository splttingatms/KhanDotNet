using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Tests
{
    public static class KhanTestData
    {
        public static Badges Badges
        {
            get
            {
                return new Badges();
            }
        }
    }

    public class Badges
    {
        public Badge FactChecker
        {
            get
            {
                return new Badge()
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
            }
        }

        public Badge ActOneSceneOne
        {
            get
            {
                return new Badge()
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
            }
        }

        public List<Badge> SampleBadges
        {
            get
            {
                return new List<Badge>()
                {
                    KhanTestData.Badges.FactChecker,
                    KhanTestData.Badges.ActOneSceneOne
                };
            }
        }

        public string SampleJson
        {
            get
            {
                return @"[{
	                ""icon_src"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"",
	                ""hide_context"": false,
	                ""description"": ""Fact Checker"",
	                ""relative_url"": ""/badges/fact-checker"",
	                ""icons"": {
		                ""small"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"",
		                ""compact"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-60x60.png"",
		                ""large"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-512x512.png"",
		                ""email"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-70x70.png""
	                },
	                ""absolute_url"": ""http://www.khanacademy.org/badges/fact-checker"",
	                ""user_badges"": null,
	                ""translated_safe_extended_description"": ""Have a clarification officially accepted"",
	                ""translated_description"": ""Fact Checker"",
	                ""is_owned"": false,
	                ""badge_category"": 1,
	                ""points"": 0,
	                ""is_retired"": false,
	                ""safe_extended_description"": ""Have a clarification officially accepted"",
	                ""slug"": ""fact-checker"",
	                ""name"": ""acceptclarificationbadge""
                },
                {
	                ""icon_src"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"",
	                ""hide_context"": false,
	                ""description"": ""Act I Scene I"",
	                ""relative_url"": ""/badges/act-i-scene-i"",
	                ""icons"": {
		                ""small"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"",
		                ""compact"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-60x60.png"",
		                ""large"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-512x512.png"",
		                ""email"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-70x70.png""
	                },
	                ""absolute_url"": ""http://www.khanacademy.org/badges/act-i-scene-i"",
	                ""user_badges"": null,
	                ""translated_safe_extended_description"": ""Watch 20 minutes of video"",
	                ""translated_description"": ""Act I Scene I"",
	                ""is_owned"": false,
	                ""badge_category"": 0,
	                ""points"": 0,
	                ""is_retired"": false,
	                ""safe_extended_description"": ""Watch 20 minutes of video"",
	                ""slug"": ""act-i-scene-i"",
	                ""name"": ""actonesceneonebadge""
                }]";
            }
        }
    }
}
