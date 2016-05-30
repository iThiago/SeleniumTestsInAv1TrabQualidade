using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Api;
using OpenQA.Selenium;
using SeleniumTests.Tests.Interface;

namespace SeleniumTests.Tests.Cliente
{
    class RootTest
    {

        private static ITest testClass;

        public RootTest(ITest testeClass)
        {
            testClass = testeClass;
        }

        
        public  void RunTests()
        {
            testClass.SetupTest();
            testClass.TheClienteTest();
            testClass.TeardownTest();
        }

    }
}
