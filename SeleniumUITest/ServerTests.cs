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
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumUITest
{
    public class Tests
    {
        private IWebDriver driver;
        string hubUrl;
        //public IDictionary<string, object> vars { get; private set; }
        //private IJavaScriptExecutor js;
 
        [SetUp]
        public void Setup()
        {
            //vars = new Dictionary<string, object>();
 
            hubUrl = "http://localhost:4444/wd/hub";
            //driver = LocalDriverFactory.CreateInstance(BrowserType.Firefox, hubUrl);




            /*EdgeOptions edgeOptions = new EdgeOptions();
            driver = new RemoteWebDriver(new Uri(hubUrl),
                edgeOptions.ToCapabilities(),
                new TimeSpan(0, 0, 15));*/

            /*OperaOptions operaOptions = new OperaOptions();
            driver = new RemoteWebDriver(new Uri(hubUrl),
                                         operaOptions.ToCapabilities(),
                           new TimeSpan(0, 3, 0));*/

            FirefoxOptions firefoxOptions = new FirefoxOptions();
            driver = new RemoteWebDriver(new Uri(hubUrl),
                                         firefoxOptions.ToCapabilities(),
                           new TimeSpan(0, 0, 15));

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
        public void AdminLoginTest()
        {


            //Creating new driver because localProjects only work with local Drivers

            new DriverManager().SetUpDriver(new EdgeConfig());

            IWebDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://localhost:44365/login");
            System.Threading.Thread.Sleep(2000);
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 780);
            driver.FindElement(By.Name("username")).Click();
            driver.FindElement(By.Name("username")).SendKeys("Auto Loan Account@acp.at");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).SendKeys("eweee");
            driver.FindElement(By.CssSelector(".btn")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.LinkText("bearbeiten")).Click();
            driver.FindElement(By.Id("buttonviewroles")).Click();
            driver.FindElement(By.Id("createrole")).Click();
            driver.FindElement(By.Id("RoleName")).Click();
            driver.FindElement(By.Id("RoleName")).SendKeys("test123");
            driver.FindElement(By.Id("Description")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("test123");
            driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
            driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
            driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
            driver.FindElement(By.Name("checkboxcustom")).Click();
            driver.FindElement(By.Id("RoleName")).Click();
            driver.FindElement(By.Id("RoleName")).SendKeys("asdasd");
            driver.FindElement(By.Id("Description")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("asdasd");
            driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
            {
                var element = driver.FindElement(By.LinkText("Applikation hinzufügen"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.FindElement(By.Name("checkboxadmin")).Click();
            driver.FindElement(By.Name("checkboxedit")).Click();
            driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
            driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
            {
                var element = driver.FindElement(By.LinkText("Applikation hinzufügen"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            
            driver.FindElement(By.Id("createRoleSubmit")).Click();




            driver.Navigate().GoToUrl("https://localhost:44365");

            System.Threading.Thread.Sleep(2000);

            IWebElement usernameInput = driver.FindElement(By.Name("username"));
            usernameInput.SendKeys("admin");

            System.Threading.Thread.Sleep(2000);

            IWebElement passwordInput = driver.FindElement(By.Name("password"));
            passwordInput.SendKeys("abcdefg");

            System.Threading.Thread.Sleep(2000);

            //IWebElement submitLogin = driver.FindElement(By.Id(".//*[@id='loginSubmit']"));
            IWebElement submitLogin = driver.FindElement(By.XPath(".//*[@id='loginSubmit']"));
            submitLogin.Click();


        }
    }
}

