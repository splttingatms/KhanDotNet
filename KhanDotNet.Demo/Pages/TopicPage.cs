using EasyConsole;
using KhanDotNet.Demo.Utilities;
using KhanDotNet.Library;

namespace KhanDotNet.Demo.Pages
{
    public class TopicPage : MenuPage
    {
        private IKhanClient _client;

        public TopicPage(Program program, IKhanClient client)
            : base("Topics", program)
        {
            Menu.Add("Get topic", GetTopicCallback);

            _client = client;
        }

        private void GetTopicCallback()
        {
            var input = Input.ReadString("Enter topic slug:");
            var topic = _client.Topics.GetTopicAsync(input).Result;
            OutputHelper.Success(topic);
        }
    }
}
