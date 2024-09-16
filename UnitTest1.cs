using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumScraping
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Define o caminho para a pasta 'encartes' dentro de Downloads
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "encartes");

            // Cria a pasta 'encartes' se ela não existir
            if (!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }

            // Nome do arquivo que será baixado (ajuste conforme o nome do arquivo que você espera baixar)
            string expectedFileName = "encarte.pdf"; // Substitua pelo nome exato do arquivo
            string fullFilePath = Path.Combine(downloadPath, expectedFileName);

            // Verifica se o arquivo já existe na pasta
            if (File.Exists(fullFilePath))
            {
                Console.WriteLine("O arquivo já existe, pulando o download.");
                return; // Encerra o teste sem fazer o download
            }

            // Configura as opções do Chrome para o download
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", downloadPath);
            options.AddUserProfilePreference("download.prompt_for_download", false); // Desativa o pop-up de confirmação de download
            options.AddUserProfilePreference("plugins.always_open_pdf_externally", true); // Força PDFs a serem baixados ao invés de abertos no navegador

            // Inicializa o driver do Chrome com as opções configuradas
            IWebDriver driver = new ChromeDriver(options);

            try
            {
                // Navega para o site do encarte
                driver.Navigate().GoToUrl("https://www.supermercadosguanabara.com.br/encarte");

                // Maximiza a janela do navegador
                driver.Manage().Window.Maximize();

                // Aguarda alguns segundos para garantir que o conteúdo seja carregado
                System.Threading.Thread.Sleep(2000);

                // Localiza o botão para baixar o encarte usando XPath (ajuste conforme necessário)
                IWebElement button = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[1]/div/div[3]/div[1]/div[1]/a[1]"));

                // Clica no botão para baixar o encarte
                button.Click();

                // Aguarda alguns segundos para garantir que o download seja processado
                System.Threading.Thread.Sleep(5000);

                // Verifica se o arquivo foi baixado com sucesso
                if (File.Exists(fullFilePath))
                {
                    Console.WriteLine("Arquivo baixado com sucesso: " + fullFilePath);
                }
                else
                {
                    Console.WriteLine("Falha no download do arquivo.");
                }

                // Reutiliza o mesmo driver para navegar para o site do ChatGPT
                driver.Navigate().GoToUrl("https://openai.com/chatgpt/");

                driver.Manage().Window.Maximize();

                // Aguarda o carregamento da página
                System.Threading.Thread.Sleep(2000);

                // Localiza o botão (ajuste conforme necessário)
                IWebElement newButton = driver.FindElement(By.XPath("//*[@id=\"main\"]/div[1]/div[1]/div/div/div/div[2]/div/a[1]"));

                // Clica no botão
                newButton.Click();

                System.Threading.Thread.Sleep(10000);
            }
            finally
            {
                // Garante que o navegador seja fechado, mesmo que ocorra algum erro
                driver.Quit();
            }
        }
    }
}