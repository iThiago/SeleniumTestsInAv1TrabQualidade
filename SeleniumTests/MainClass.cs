using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Tests.Interface;
using SeleniumTests.Tests.Cliente;

namespace SeleniumTests
{
    public class MainClass
    {

        public static void Main(String[] args)
        {

            RodarTeste(new AddClienteCpfInvalido(new ChromeDriver()));
            RodarTeste(new AddCliente(new ChromeDriver()));
            RodarTeste(new EditCliente(new ChromeDriver()));
            RodarTeste(new DeleteCliente(new ChromeDriver()));
            RodarTeste(new AddClienteCamposNulos(new ChromeDriver()));
            

        }

        private static void RodarTeste(ITest classeTeste)
        {
            RootTest rootTest = new RootTest(classeTeste);
            rootTest.RunTests();
        }

    }
}
