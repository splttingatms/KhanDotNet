using EasyConsole;
using KhanDotNet.Demo.Pages;
using KhanDotNet.Library;
using System;

namespace KhanDotNet.Demo
{
    class KhanDotNetDemo : Program, IDisposable
    {
        private IKhanClient _client;

        public KhanDotNetDemo()
            : base("KhanDotNet Demo", true)
        {
            _client = new KhanClient();

            AddPage(new ResourcePage(this));
            AddPage(new BadgePage(this, _client));
            AddPage(new ExercisePage(this, _client));

            SetPage<ResourcePage>();
        }

        public void Dispose()
        {
            _client?.Dispose();
            _client = null;
        }
    }
}
