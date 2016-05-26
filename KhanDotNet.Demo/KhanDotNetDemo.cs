using EasyConsole;
using EnsureThat;
using KhanDotNet.Demo.Pages;
using KhanDotNet.Library;
using System;
using System.Configuration;

namespace KhanDotNet.Demo
{
    class KhanDotNetDemo : Program, IDisposable
    {
        private IKhanClient _client;

        public KhanDotNetDemo()
            : base("KhanDotNet Demo", true)
        {
            // TODO 1: allow developer to not specify consumer cred and only use public APIs
            var credentials = GetConsumerCredentials();
            var authenticator = GetAuthenticator(credentials);
            _client = new KhanClient(authenticator, credentials);

            AddPage(new ResourcePage(this));
            AddPage(new BadgePage(this, _client));
            AddPage(new ExercisePage(this, _client));
            AddPage(new TopicPage(this, _client));
            AddPage(new TopicTreePage(this, _client));
            AddPage(new UserPage(this, _client));

            SetPage<ResourcePage>();
        }

        private ConsumerCredentials GetConsumerCredentials()
        {
            var consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            var consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];

            Ensure.That(consumerKey, nameof(consumerKey))
                .WithExtraMessageOf(() => "Must specify consumer key in app settings")
                .IsNotNullOrEmpty();
            Ensure.That(consumerSecret, nameof(consumerSecret))
                .WithExtraMessageOf(() => "Must specify consumer secret in app settings")
                .IsNotNullOrEmpty();

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
