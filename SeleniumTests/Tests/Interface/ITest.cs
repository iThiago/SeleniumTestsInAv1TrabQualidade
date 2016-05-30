using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTests.Tests.Interface
{
    interface ITest
    {

        void SetupTest();
        void TheClienteTest();
        void TeardownTest();
    }

}
