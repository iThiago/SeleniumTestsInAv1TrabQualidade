using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumTests.Tests.Interface;

namespace SeleniumTests
{
    [TestFixture]
    public class DeleteCliente : AbstractTest
    {

        public DeleteCliente(IWebDriver drive)
        {
            driver = drive;
        }

        public DeleteCliente()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public override void TheClienteTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            Assert.IsTrue(driver.Title.Contains("Cadastro"));
        }
     
    }
}
