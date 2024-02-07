using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Reflection.Metadata;
using System;

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



            //// Явное ожидание появления элемента с идентификатором "inp" до 20 секунд
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            //try
            //{
            //    IWebElement searchBox = wait.Until(d => d.FindElement(By.CssSelector("#editor_text")));
            //    searchBox.SendKeys("Selenium C#");

            //    // Нажатие кнопки поиска
            //    searchBox.SendKeys(Keys.Enter);

            //    // Проверка результатов
            //    Assert.IsTrue(searchBox.Text.Contains("Selenium C#"));

            //}
            //catch (WebDriverTimeoutException ex)
            //{
            //    Console.WriteLine($"Таймаут. Элемент с идентификатором 'editor_text' не найден: {ex.Message}");
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
                //IWebElement imageElements = driver.FindElement(By.CssSelector("div.product-thumb img"));
                // Найти изображение (предполагается, что у изображения есть уникальный атрибут или класс)
                IWebElement imageElement = wait.Until(d => d.FindElement(By.CssSelector("div.product-thumb img")));

                // Нажать на изображение
                imageElement.Click();

               driver.Navigate().Back();
                IWebElement searchBox = wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/nav/div[2]/ul/li[1]/a")));
                searchBox.SendKeys(Keys.Enter);
                searchBox = wait.Until(d => d.FindElement(By.CssSelector("div.container:nth-child(3) nav.navbar div.collapse.navbar-collapse.navbar-ex1-collapse ul.nav.navbar-nav li.dropdown:nth-child(1) div.dropdown-menu div.dropdown-inner ul.list-unstyled li:nth-child(1) > a:nth-child(1)")));
                searchBox.SendKeys(Keys.Enter);
           
                 searchBox = wait.Until(d => d.FindElement(By.CssSelector("body:nth-child(2) div.container:nth-child(4) div.row div.col-sm-9 > p:nth-child(2)")));
                //bool i = searchBox.Text.Contains("В данной категори");

                bool i = searchBox.Text == "В данной категории нет";
                Assert.IsTrue(searchBox.Text == "В данной категории нет товаров.");
                //driver.Navigate().Back();
                 searchBox = wait.Until(d => d.FindElement(By.XPath("/html/body/nav/div/div/ul/li[2]/a")));
                 searchBox.SendKeys(Keys.Enter);
                 searchBox = wait.Until(d => d.FindElement(By.XPath("/html/body/nav/div/div/ul/li[2]/ul/li[1]/a")));
                 searchBox.SendKeys(Keys.Enter);
                 searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[2]/div[1]/input[1]")));
                 searchBox.SendKeys("Maksim");
                 searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[3]/div[1]/input[1]")));
                 searchBox.SendKeys("Бобрецов");
                 searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[4]/div[1]/input[1]")));
                 searchBox.SendKeys("test@mail.ru");
                 searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/input[1]")));
                 searchBox.SendKeys("+79226012118");
                searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[2]/div[1]/div[1]/input[1]")));
                searchBox.SendKeys("1111");
                searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[2]/div[2]/div[1]/input[1]")));
                searchBox.SendKeys("1111");
                searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[3]/div[1]/div[1]/label[2]")));
                searchBox.SendKeys(Keys.Enter);
                searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[1]/input[1]")));
                searchBox.Click();
                searchBox = wait.Until(d => d.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/form[1]/div[1]/div[1]/input[2]")));
                searchBox.Click();
                /////html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[2]/div[1]/div[1]/input[1]
            }
            catch (WebDriverTimeoutException)
            {
            }
            finally
            {
                // Проверка результатов

                driver.Quit();
            }
        }
    }
    
}
