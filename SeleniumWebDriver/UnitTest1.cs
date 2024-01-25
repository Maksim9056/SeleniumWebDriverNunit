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

            // ����� �������� ��������� �������� � ��������������� "inp" �� 20 ������
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            try
            {
                IWebElement searchBox = wait.Until(driver => driver.FindElement(By.CssSelector("#inp")));
                searchBox.SendKeys("Selenium C#");

                // ������� ������ ������
                searchBox.SendKeys(Keys.Enter);

                // �������� �����������
                Assert.IsTrue(driver.Title.Contains("Selenium C#"));
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"�������. ������� � ��������������� 'inp' �� ������: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
