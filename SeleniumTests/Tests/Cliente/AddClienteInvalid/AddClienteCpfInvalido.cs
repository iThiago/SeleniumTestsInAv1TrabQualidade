using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Tests.Interface;

namespace SeleniumTests
{
    [TestFixture]
    public class AddClienteCpfInvalido : AbstractTest
    {

        public AddClienteCpfInvalido(IWebDriver drive)
        {
            driver = drive;
        }

        public AddClienteCpfInvalido()
        {
            driver = new ChromeDriver();
        }
        
        public override void TheClienteTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.FindElement(By.Id("Nome")).Clear();
            driver.FindElement(By.Id("Nome")).SendKeys("ClienteTeste Cpf Invalido - " + new Random().Next(1, 9999).ToString());
            driver.FindElement(By.Id("Cpf")).Clear();
            driver.FindElement(By.Id("Cpf")).SendKeys("123112343434312");
            driver.FindElement(By.Id("Endereco")).Clear();
            driver.FindElement(By.Id("Endereco")).SendKeys("Teste de endereco");
            driver.FindElement(By.Id("Telefone")).Clear();
            driver.FindElement(By.Id("Telefone")).SendKeys("21321342");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            
            Assert.IsFalse(driver.Title.Contains("Details"));
        }
        [Test]
        public void AddCliente_DevePassarRetornarCPFInvalido()
        {
            TheClienteTest();
        }

    }
}
