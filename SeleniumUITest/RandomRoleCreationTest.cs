

//ignore

/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class RandomRoleCreationTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), new ChromeOptions().ToCapabilities());
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void randomRoleCreationTest()
    {
        driver.Navigate().GoToUrl("https://localhost:44365/login?ReturnUrl=%2F");
        driver.Manage().Window.Size = new System.Drawing.Size(1440, 780);
        driver.FindElement(By.Name("username")).Click();
        driver.FindElement(By.Name("username")).SendKeys("Auto Loan Account@acp.at");
        driver.FindElement(By.Name("password")).Click();
        driver.FindElement(By.Name("password")).SendKeys("eweee");
        driver.FindElement(By.CssSelector(".btn")).Click();
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
        driver.FindElement(By.XPath("(//input[@name=\'checkboxedit\'])[2]")).Click();
        driver.FindElement(By.Id("RoleName")).Click();
        driver.FindElement(By.Id("RoleName")).SendKeys("aaaabbbb");
        driver.FindElement(By.Id("Description")).Click();
        driver.FindElement(By.Id("Description")).SendKeys("asdasdas");
        driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
        {
            var element = driver.FindElement(By.LinkText("Applikation hinzufügen"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
        {
            var element = driver.FindElement(By.LinkText("Applikation hinzufügen"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
        driver.FindElement(By.LinkText("Applikation hinzufügen")).Click();
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        driver.FindElement(By.XPath("(//input[@name=\'checkboxcustom\'])[3]")).Click();
        driver.FindElement(By.Id("RoleName")).Click();
        driver.FindElement(By.Id("RoleName")).SendKeys("ewerwre");
        driver.FindElement(By.Id("Description")).Click();
        driver.FindElement(By.Id("Description")).SendKeys("werwer");
        driver.FindElement(By.Id("createRoleSubmit")).Click();
    }
}
*/