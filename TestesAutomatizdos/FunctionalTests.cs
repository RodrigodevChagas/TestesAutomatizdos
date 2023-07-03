using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestesAutomatizdos
{
    [TestFixture]
    public class FunctionalTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Configurar o caminho para o driver do Chrome
            var chromeDriverPath = @"C:\Caminho\para\chromedriver.exe";

            // Inicializar o driver do Chrome
            driver = new ChromeDriver(chromeDriverPath);
        }

        [Test]
        public void TestLogin()
        {
            // Navegar para a página de login
            driver.Navigate().GoToUrl("https://www.example.com/login");

            // Encontrar os elementos do formulário de login e realizar ações
            IWebElement usernameInput = driver.FindElement(By.Id("username"));
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

            usernameInput.SendKeys("username");
            passwordInput.SendKeys("password");
            loginButton.Click();

            // Verificar se o login foi bem-sucedido
            Assert.IsTrue(driver.Url.Contains("dashboard"));
        }

        [TearDown]
        public void Teardown()
        {
            // Fechar o navegador
            driver.Quit();
        }
    }
}