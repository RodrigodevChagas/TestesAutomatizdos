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
            IWebElement botaoEntrar = driver.FindElement(By.XPath("//div[2]/div[2]/div/div/a"));
            //IWebElement passwordInput = driver.FindElement(By.Id("pass"));
            //IWebElement loginButton = driver.FindElement(By.Id("u_0_5_hh"));
            
            botaoEntrar.Click();

            IWebElement campoEmail = driver.FindElement(By.XPath("//div[1]/form/fieldset/div/input"));

            campoEmail.SendKeys("monikamalpha@gmail.com");


            // Verificar se o login foi bem-sucedido
            Assert.IsTrue(driver.Url.Contains("id"));
        }
        
        //[Test]
        //public void TestLogin2()
        //{
        //    // Navegar para a página de login
        //    driver.Navigate().GoToUrl("https://www.bne.com.br/");

        //    // Encontrar os elementos do formulário de login e realizar ações
        //    IWebElement botaoEntrar = driver.FindElement(By.XPath("//div[2]/div[2]/div/div/a"));
        //    //IWebElement passwordInput = driver.FindElement(By.Id("pass"));
        //    //IWebElement loginButton = driver.FindElement(By.Id("u_0_5_hh"));

        //    botaoEntrar.Click();
     
           


        //    // Verificar se o login foi bem-sucedido
        //    Assert.IsTrue(driver.Url.Contains("id"));
        //}

        [TearDown]
        public void Teardown()
        {
            // Fechar o navegador
            driver.Quit();
        }
    }
}