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
    public class AddCliente : AbstractTest
    {
        
        private bool acceptNextAlert = true;
        
        public AddCliente(IWebDriver driv)
        {
            driver = driv;
        }

        public AddCliente()
        {
            driver = new ChromeDriver();
        }
        
        public override void TheClienteTest()
        {
           
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.FindElement(By.Id("Nome")).Clear();
            driver.FindElement(By.Id("Nome")).SendKeys("Cliente Teste - " + new Random().Next(1,9999).ToString());
            driver.FindElement(By.Id("Cpf")).Clear();
            driver.FindElement(By.Id("Cpf")).SendKeys("1231231231");
            driver.FindElement(By.Id("Endereco")).Clear();
            driver.FindElement(By.Id("Endereco")).SendKeys("Teste de Endereco");
            driver.FindElement(By.Id("Telefone")).Clear();
            driver.FindElement(By.Id("Telefone")).SendKeys("21321342");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            driver.FindElement(By.LinkText("Back to List")).Click();

            Assert.IsTrue(driver.Title.Contains("Cadastro"));

        }

        [Test]
        public void AddCliente_DevePassarEAddCliente()
        {
            TheClienteTest();
        }

    }

}
