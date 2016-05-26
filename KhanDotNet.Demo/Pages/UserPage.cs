using EasyConsole;
using KhanDotNet.Demo.Utilities;
using KhanDotNet.Library;

namespace KhanDotNet.Demo.Pages
{
    class UserPage : MenuPage
    {
        private IKhanClient _client;

        public UserPage(Program program, IKhanClient client)
            : base("Badges", program)
        {
            Menu.Add("Get user", GetUserCallback);

            _client = client;
        }

        private void GetUserCallback()
        {
            var user = _client.Users.GetUserAsync().Result;
            OutputHelper.Success(user);
        }
    }
}
