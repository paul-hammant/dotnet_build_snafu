using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetPoC.UiTest
{
    [SetUpFixture]
    public class BeforeAndAfterTestRunHooks
    {
        private static CancellationTokenSource _cancelToken = new CancellationTokenSource();

        public static IWebDriver? Driver;
        
        [OneTimeSetUp]
        public static void BeforeTestRun()
        {

            Driver = new ChromeDriver();
            //Driver.Manage().Window.Maximize();

            Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webbuilder =>
            {
                webbuilder.UseStartup<TestExtendedDotNetPoCStartup>();
            }).Build().Run();

        }

        [OneTimeTearDown]
        public static void AfterTestRun()
        {
           _cancelToken.Cancel();
            Driver.Quit();
        }

    }
}
