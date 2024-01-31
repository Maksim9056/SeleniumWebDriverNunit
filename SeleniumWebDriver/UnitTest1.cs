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



            // ����� �������� ��������� �������� � ��������������� "inp" �� 20 ������
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            try
            {
                IWebElement searchBox = wait.Until(d => d.FindElement(By.CssSelector("#editor_text")));
                searchBox.SendKeys("Selenium C#");

                // ������� ������ ������
                searchBox.SendKeys(Keys.Enter);

                // �������� �����������
                Assert.IsTrue(searchBox.Text.Contains("Selenium C#"));

            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"�������. ������� � ��������������� 'editor_text' �� ������: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
