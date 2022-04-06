using NUnit.Framework;

namespace DotNetPoC.UiTest
{
    [TestFixture]
    public class MyUiTest
    {
        [Test]
        public void TestSomething()
        {
            //Thread.Sleep(10000);
            BeforeAndAfterTestRunHooks.Driver.Navigate().GoToUrl("http://localhost:7171/");
            Assert.AreEqual("hello", BeforeAndAfterTestRunHooks.Driver.Title);
        }
    }
}