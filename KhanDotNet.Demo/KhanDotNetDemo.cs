using EasyConsole;
using KhanDotNet.Demo.Pages;
using KhanDotNet.Library;
using System;
using System.Configuration;
using System.Diagnostics;

namespace KhanDotNet.Demo
{
    class KhanDotNetDemo : Program, IDisposable
    {
        private IKhanClient _client;

        public KhanDotNetDemo()
            : base("KhanDotNet Demo", true)
        {
            _client = GetClient();

            AddPage(new ResourcePage(this));
            AddPage(new BadgePage(this, _client));
            AddPage(new ExercisePage(this, _client));
            AddPage(new TopicPage(this, _client));
            AddPage(new TopicTreePage(this, _client));
            AddPage(new UserPage(this, _client));

            SetPage<ResourcePage>();
        }

        private IKhanClient GetClient()
        {
            var credentials = GetConsumerCredentials();

            if (credentials == null)
            {
                Trace.TraceWarning("No credentials specified in app settings so only public APIs will be available");
                return new KhanClient();
            }

            var authenticator = GetAuthenticator(credentials);
            return new KhanClient(authenticator, credentials);
        }

        private ConsumerCredentials GetConsumerCredentials()
        {
            var consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            var consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];

            if (string.IsNullOrEmpty(consumerKey) || string.IsNullOrEmpty(consumerSecret))
                return null;

            return new ConsumerCredentials(consumerKey, consumerSecret);
        }

        private IAuthentication GetAuthenticator(ConsumerCredentials credentials)
        {
            var accessToken = ConfigurationManager.AppSettings["AccessToken"];
            var accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];

            // Use web authenticator if developer has not specified access token in settings
            return (string.IsNullOrEmpty(accessToken))
                ? new WebAuthentication(credentials) as IAuthentication
                : new StaticAuthentication(accessToken, accessTokenSecret);
        }

        public void Dispose()
        {
            _client?.Dispose();
            _client = null;
        }
    }
}
