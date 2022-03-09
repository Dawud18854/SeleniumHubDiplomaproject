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
using WebDriverManager;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumUITest
{
    

    public class LocalLoadTests
    {
        public IWebDriver driver;

        
        public IWebDriver Init()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());

            return new EdgeDriver();
        }


        [Test, Order(1)]
        public void AdminLoginTest()
        {
            driver = Init();

            driver.Navigate().GoToUrl("https://localhost:44365");

            System.Threading.Thread.Sleep(2000);

            IWebElement usernameInput = driver.FindElement(By.Name("username"));
            usernameInput.SendKeys("admin");

            System.Threading.Thread.Sleep(2000);

            IWebElement passwordInput = driver.FindElement(By.Name("password"));
            passwordInput.SendKeys("abcdefg");

            System.Threading.Thread.Sleep(2000);

            IWebElement submitLogin = driver.FindElement(By.XPath(".//*[@id='loginSubmit']"));
            submitLogin.Click();

        }

        [Test, Order(2)]
        public void ExecutiveLoginTest() // Variant through SeleniumIDE instead of manually writing code
        {

            driver = Init();

            driver.Navigate().GoToUrl("https://localhost:44365/login");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 780);
            driver.FindElement(By.Name("username")).Click();
            driver.FindElement(By.Name("username")).SendKeys("withdrawal@acp.at");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).SendKeys("eweee");
            driver.FindElement(By.CssSelector(".btn")).Click();

        }

        [Test, Order(3)]
        public void CreateRoleWithExecutiveTest()
        {
            //init
            driver = Init();

            driver.Navigate().GoToUrl("https://localhost:44365/login");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 780);
            driver.FindElement(By.Name("username")).Click();
            driver.FindElement(By.Name("username")).SendKeys("withdrawal@acp.at");
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
            {
                var element = driver.FindElement(By.LinkText("Applikation hinzufügen"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }

            driver.FindElement(By.Id("createRoleSubmit")).Click();

        }

        

        
    }
}

