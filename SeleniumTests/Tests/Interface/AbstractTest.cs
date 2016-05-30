using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTests.Tests.Interface
{
    public abstract class AbstractTest : ITest
    {
        private ITest _testImplementation;
        public IWebDriver driver;
        public StringBuilder verificationErrors;
        public string baseURL = "http://localhost:53544/";

        
        [SetUp]
        public void SetupTest()
        {
            verificationErrors = new StringBuilder();
        }
       

        [TearDown]
        public void TeardownTest()
        {

            try
            {
                Thread.Sleep(3000);
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        public abstract void TheClienteTest();

    }
}
