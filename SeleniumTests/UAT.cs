using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumTests
{
    [TestClass]
    public class UAT
    {
        // .runsettings file contains test run parameters
        // e.g. URI for app
        // test context for this run

        private TestContext testContextInstance;

        // test harness uses this property to initliase test context
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        // URI for web app being tested
        private string webAppUrl;

        // .runsettings property overriden in vsts test runner
        // release task
        [TestInitialize]                // run before each unit test
        public void Setup()
        {
            this.webAppUrl = testContextInstance.Properties["webAppUrl"].ToString();
        }

        [TestMethod]
        public void TestChrome()
        {
            //Arrange
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            IWebDriver chromeBrowser = new ChromeDriver(chromeOptions);
            //chromeBrowser.Navigate().GoToUrl("https://planetweight-qa.azurewebsites.net");
            System.Console.WriteLine(this.webAppUrl);
            chromeBrowser.Navigate().GoToUrl(this.webAppUrl);

            chromeBrowser.FindElement(By.Id("planetWeight_weight")).Click();
            chromeBrowser.FindElement(By.Id("planetWeight_weight")).SendKeys("20");
            chromeBrowser.FindElement(By.CssSelector(".btn")).Click();
            chromeBrowser.FindElement(By.CssSelector(".form-group:nth-child(4)")).Click();

            //Act
            string expectedResult = "Your Weight on that Planet: 7.6";
            string actualResult = chromeBrowser.FindElement(By.CssSelector(".form-group:nth-child(4)")).Text;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

            Thread.Sleep(5000);

            chromeBrowser.Close();
            chromeBrowser.Quit();
        }

        [TestMethod]
        public void TestEdge()
        {
            //Arrange
            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArguments("--headless");

            IWebDriver edgeBrowser = new EdgeDriver(edgeOptions);
            //chromeBrowser.Navigate().GoToUrl("https://planetweight-qa.azurewebsites.net");
            System.Console.WriteLine(this.webAppUrl);
            edgeBrowser.Navigate().GoToUrl(this.webAppUrl);

            edgeBrowser.FindElement(By.Id("planetWeight_weight")).Click();
            edgeBrowser.FindElement(By.Id("planetWeight_weight")).SendKeys("20");
            edgeBrowser.FindElement(By.CssSelector(".btn")).Click();
            edgeBrowser.FindElement(By.CssSelector(".form-group:nth-child(4)")).Click();

            //Act
            string expectedResult = "Your Weight on that Planet: 7.6";
            string actualResult = edgeBrowser.FindElement(By.CssSelector(".form-group:nth-child(4)")).Text;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

            Thread.Sleep(5000);

            edgeBrowser.Close();
            edgeBrowser.Quit();
        }
    }
}