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
            ////var edgeOptions = new EdgeOptions();
            ////var edgeOptions = new ChromeOptions();

            ////IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            //var chromeOptions = new ChromeOptions();
            //IWebDriver driver = new ChromeDriver(@"C:\chromedriver-win64\", chromeOptions);


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //driver.Navigate().GoToUrl("https://konflic.github.io/examples/editor/index.html");



            //// ����� �������� ��������� �������� � ��������������� "inp" �� 20 ������
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            //try
            //{
            //    IWebElement searchBox = wait.Until(d => d.FindElement(By.CssSelector("#editor_text")));
            //    searchBox.SendKeys("Selenium C#");

            //    // ������� ������ ������
            //    searchBox.SendKeys(Keys.Enter);

            //    // �������� �����������
            //    Assert.IsTrue(searchBox.Text.Contains("Selenium C#"));

            //}
            //catch (WebDriverTimeoutException ex)
            //{
            //    Console.WriteLine($"�������. ������� � ��������������� 'editor_text' �� ������: {ex.Message}");
            //}
            //finally
            //{
            //    driver.Quit();
            //}div.container:nth-child(4) div.row div.col-sm-12 div.row:nth-child(4) div.product-layout.col-lg-3.col-md-3.col-sm-6.col-xs-12:nth-child(2) div.product-thumb.transition div.image a:nth-child(1) > img.img-responsive
       
        }

        [Test]
        public void SecondSeleniumTest()
        {
            var chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(@"C:\chromedriver-win64\", chromeOptions);
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.Navigate().GoToUrl("https://demo-opencart.ru/index.php?route=common/home");
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                // ����� ����������� (��������������, ��� � ����������� ���� ���������� ������� ��� �����)
                IWebElement imageElement = wait.Until(d => d.FindElement(By.CssSelector("div.product-thumb img")));

                // ������ �� �����������
                imageElement.Click();

               driver.Navigate().Back();

                IWebElement searchBox = wait.Until(d => d.FindElement(By.CssSelector("div.container:nth-child(3) nav.navbar div.collapse.navbar-collapse.navbar-ex1-collapse ul.nav.navbar-nav li.dropdown:nth-child(1) div.dropdown-menu div.dropdown-inner ul.list-unstyled li:nth-child(1) > a:nth-child(1)")));

                searchBox.SendKeys(Keys.Enter);


            }
            catch (WebDriverTimeoutException)
            {
            }
            finally
            {
                // �������� �����������

                driver.Quit();
            }
        }
    }
    
}
