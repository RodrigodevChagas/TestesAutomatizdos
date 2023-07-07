using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestesAutomatizados
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Configurar o caminho para o driver do Chrome
            var chromeDriverPath = @"L:\chromedriver\chromedriver.exe"; 

            // Inicializar o driver do Chrome
            driver = new ChromeDriver(chromeDriverPath);
        }

        [Test]
        public void TestLogin()
        {
            // Navegar para a página de login
            driver.Navigate().GoToUrl("https://www.bne.com.br/");

            // Encontrar os elementos do formulário de login e realizar ações
            IWebElement botaoEntrar = driver.FindElement(By.Id("BtnDirectLoginNonSTC"));
            botaoEntrar.Click();

            IWebElement campoEmail = driver.FindElement(By.Id("newloginEmailInput"));
            campoEmail.SendKeys("monikamalpha@gmail.com");

            IWebElement botaoContinuar = driver.FindElement(By.Id("loginHandlerBtn"));
            botaoContinuar.Click();

            Thread.Sleep(2000);
            IWebElement campoSenha = driver.FindElement(By.Id("newPasswordInput"));
            campoSenha.SendKeys("M0nik@30207&@#&");

            IWebElement botaoConcluirLogin = driver.FindElement(By.Id("loginHandlerBtn"));
            botaoConcluirLogin.Click();

            // Verificar se o login foi bem-sucedido
            Assert.IsTrue(driver.Url.Contains("sala-vip"));
        }
        
        [TearDown]
        public void Teardown()
        {
            // Fechar o navegador
            driver.Quit();
        }
    }
}