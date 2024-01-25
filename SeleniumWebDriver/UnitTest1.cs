using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriver
{
    public class Tests
    {
        [Test]
        public void FirstSeleniumTest()
        {
            var edgeOptions = new EdgeOptions();

            IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            driver.Navigate().GoToUrl("https://konflic.github.io/examples/editor/index.html");

            // Явное ожидание появления элемента с идентификатором "inp" до 20 секунд
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            try
            {
                IWebElement searchBox = wait.Until(driver => driver.FindElement(By.CssSelector("#inp")));
                searchBox.SendKeys("Selenium C#");

                // Нажатие кнопки поиска
                searchBox.SendKeys(Keys.Enter);

                // Проверка результатов
                Assert.IsTrue(driver.Title.Contains("Selenium C#"));
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"Таймаут. Элемент с идентификатором 'inp' не найден: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
