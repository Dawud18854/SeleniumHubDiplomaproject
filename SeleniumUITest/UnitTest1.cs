using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Edge;


namespace SeleniumUITest
{
    public class Tests
    {
        private IWebDriver driver;
        string hubUrl;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
 
        [SetUp]
        public void Setup()
        {
            vars = new Dictionary<string, object>();
 
            hubUrl = "http://localhost:4444/wd/hub";
            //driver = LocalDriverFactory.CreateInstance(BrowserType.Firefox, hubUrl);
            
            
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            driver = new RemoteWebDriver(new Uri(hubUrl),
                                         firefoxOptions.ToCapabilities(),
                           new TimeSpan(0, 3, 0));
            
            EdgeOptions edgeOptions = new EdgeOptions();
            driver = new RemoteWebDriver(new Uri(hubUrl),
                edgeOptions.ToCapabilities(),
                new TimeSpan(0, 3, 0));
                
            //js = (IJavaScriptExecutor)driver;
        }
 
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
 
        [Test]
        [Parallelizable]
        public void OpenGoogleAndSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("I Want to se this on a remote machine");
        }
 
        [Test]
        [Parallelizable]
        public void OpenBingAndSearch()
        {
            driver.Navigate().GoToUrl("https://www.bing.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("I Want to seee this on a remote machine");
        }
 
        [Test]
        [Parallelizable]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("https://localhost:4765/");
            driver.Manage().Window.Maximize();
            
            
            
        }
    }
}
