using EasyConsole;
using KhanDotNet.Demo.Utilities;
using KhanDotNet.Library;

namespace KhanDotNet.Demo.Pages
{
    public class TopicTreePage : MenuPage
    {
        private IKhanClient _client;

        public TopicTreePage(Program program, IKhanClient client)
            : base("Topic Tree", program)
        {
            Menu.Add("Get topic tree", GetTopicTreeCallback);

            _client = client;
        }

        private void GetTopicTreeCallback()
        {
            var tree = _client.TopicTree.GetTopicTreeAsync().Result;
            OutputHelper.Success(tree);
        }
    }
}