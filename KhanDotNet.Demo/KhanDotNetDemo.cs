using EasyConsole;
using KhanDotNet.Demo.Pages;
using KhanDotNet.Library;
using KhanDotNet.Library.Authentication;
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

        public void Dispose()
        {
            _client?.Dispose();
            _client = null;
        }

        private IKhanClient GetClient()
        {
            IConsumerCredentialsRetriever consumerCredentialsRetriever;
            if (ConfigurationManager.AppSettings["ConsumerKey"] == null)
            {
                Trace.TraceWarning("No consumer key in app settings, only public APIs will be available");
                return new KhanClient();
            }
            else
            {
                consumerCredentialsRetriever = new ConfigConsumerCredentialsRetriever("ConsumerKey", "ConsumerSecret");
            }


            IAccessTokenRetriever accessTokenRetriever;
            if (ConfigurationManager.AppSettings["AccessToken"] == null)
            {
                Trace.TraceWarning("No access token in app settings, defaulting to using web retriever instead");
                accessTokenRetriever = new WebAccessTokenRetriever(consumerCredentialsRetriever);
            }
            else
            {
                accessTokenRetriever = new ConfigAccessTokenRetriever("AccessToken", "AccessTokenSecret");
            }

            var authenticator = new Authenticator(consumerCredentialsRetriever, accessTokenRetriever);
            return new KhanClient(authenticator);
        }
    }
}
