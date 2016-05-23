using EasyConsole;
using KhanDotNet.Library;
using KhanDotNet.Library.Contract;
using KhanDotNet.Demo.Utilities;

namespace KhanDotNet.Demo.Pages
{
    class BadgePage : MenuPage
    {
        private IKhanClient _client;

        public BadgePage(Program program, IKhanClient client)
            : base("Badges", program)
        {
            Menu.Add("Get badges", GetBadgesCallback);
            Menu.Add("Get badge categories", GetBadgeCategoriesCallback);
            Menu.Add("Get badge category", GetBadgeCategoryCallback);

            _client = client;
        }

        private void GetBadgesCallback()
        {
            var badges = _client.Badges.GetBadgesAsync().Result;
            OutputHelper.Success(badges);
        }

        private void GetBadgeCategoriesCallback()
        {
            var categories = _client.Badges.GetBadgeCategoriesAsync().Result;
            OutputHelper.Success(categories);
        }

        private void GetBadgeCategoryCallback()
        {
            Category input = Input.ReadEnum<Category>("Select badge category:");

            var category = _client.Badges.GetBadgeCategoryAsync(input).Result;
            OutputHelper.Success(category);
        }
    }
}
