using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetPOC.UITests
{
    [TestFixture]
    public class HelloTests
    {
        [Test]
        public void StartApplication()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://localhost:7171/");
                var title = driver.Title;
                Assert.AreEqual("hello", title);
            }
        }
    }
}