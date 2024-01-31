using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    public class Tests
    {
        [Test]
        public void FirstSeleniumTest()
        {
            //var edgeOptions = new EdgeOptions();
            //var edgeOptions = new ChromeOptions();

            //IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            var chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(@"C:\chromedriver-win64\", chromeOptions);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://konflic.github.io/examples/editor/index.html");



            // Явное ожидание появления элемента с идентификатором "inp" до 20 секунд
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            try
            {
                IWebElement searchBox = wait.Until(d => d.FindElement(By.CssSelector("#editor_text")));
                searchBox.SendKeys("Selenium C#");

                // Нажатие кнопки поиска
                searchBox.SendKeys(Keys.Enter);

                // Проверка результатов
                Assert.IsTrue(searchBox.Text.Contains("Selenium C#"));

            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"Таймаут. Элемент с идентификатором 'editor_text' не найден: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
