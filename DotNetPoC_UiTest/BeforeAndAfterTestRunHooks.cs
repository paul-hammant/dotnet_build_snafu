using System.Threading;
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
            
            Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webbuilder =>
            {
                webbuilder.UseStartup<TestExtendedDotNetPoCStartup>();
            }).Build().RunAsync(_cancelToken.Token);

        }

        [OneTimeTearDown]
        public static void AfterTestRun()
        {
            _cancelToken.Cancel();
            Driver.Quit();
        }

    }
}
