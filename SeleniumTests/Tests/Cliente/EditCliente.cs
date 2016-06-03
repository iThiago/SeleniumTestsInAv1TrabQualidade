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
    public class EditCliente : AbstractTest
    {

        public EditCliente(IWebDriver drive)
        {
            driver = drive;
        }

        public EditCliente()
        {
            driver = new ChromeDriver();

        }

        public override void TheClienteTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.FindElement(By.Id("Nome")).Clear();
            driver.FindElement(By.Id("Nome")).SendKeys("Cliente Editado - " + new Random().Next(1, 9999).ToString());
            driver.FindElement(By.Id("Cpf")).Clear();
            driver.FindElement(By.Id("Cpf")).SendKeys("12312121");
            driver.FindElement(By.Id("Endereco")).Clear();
            driver.FindElement(By.Id("Endereco")).SendKeys("123 Editado");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();

            Assert.IsTrue(driver.Title.Contains("Cadastro"));
        }

        [Test]
        public void EditCliente_DevePassarClienteValido()
        {
            TheClienteTest();
        }

    }
}
