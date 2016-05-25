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
            Menu.Add("Get topic exercises", GetTopicExercisesCallback);

            _client = client;
        }

        private void GetTopicCallback()
        {
            var input = Input.ReadString("Enter topic slug:");
            var topic = _client.Topics.GetTopicAsync(input).Result;
            OutputHelper.Success(topic);
        }

        private void GetTopicExercisesCallback()
        {
            var input = Input.ReadString("Enter topic slug:");
            var exercises = _client.Topics.GetTopicExercisesAsync(input).Result;
            OutputHelper.Success(exercises);
        }
    }
}
