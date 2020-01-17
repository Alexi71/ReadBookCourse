using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ReadBooks.Test
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLauAppNavigatesToLogin()
        {
            
            app.Tap(x => x.Text("Login"));
            //app.Repl();

            var result = app.Query(x => x.Marked("LoginPageButton"));
            Assert.IsTrue(result.Any(), "Navigation to Login didin't happen");
        }
    }
}
