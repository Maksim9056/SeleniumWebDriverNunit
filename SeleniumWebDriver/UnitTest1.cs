using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Reflection.Metadata;
using System;
using System.Xml.Linq;

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
        public string категория = "В данной категории нет";
        public string категориянастоящая = "В данной категории нет товаров.";
        public string Name = "Maksim";
        public string FirstName = "Бобрецов";
        public string Mail = "testmaksimbc@mail.ru";
        public string PhoneNumbers = "+79226012118";
        public string Password = "1111";


        public string критерииложПоиска = "Нет товаров, которые соответствуют критериям";
        public string критерииПоиска = "Нет товаров, которые соответствуют критериям поиска.";
        public string Text = "Selenium C#";
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
                // Найти изображение (предполагается, что у изображения есть уникальный атрибут или класс)
                Product product = new Product();
                product.AddWebDriver(wait);
                product.ImageClick();
                driver.Navigate().Back();
                Компьютеры компьютеры = new  Компьютеры();
                компьютеры.AddWeb(wait, категория, категориянастоящая);
                компьютеры.Kategroy();
                компьютеры.FindClicPC();
                компьютеры.CheckKategory();
                RegUsers regUsers = new RegUsers();
                regUsers.AddParametrRegUsers(wait, Name,FirstName,Mail, PhoneNumbers,Password);
                regUsers.RegUserStart();
                regUsers.EnterName();
                regUsers.EnterFirstName();
                regUsers.EnterMail();
                regUsers.EnterPhoneNumbers();
                regUsers.EnterPassword();
                regUsers.EnterRepeatPassword();
                regUsers.ClickPoint();
                regUsers.ClicklointCheckV();
                regUsers.ClickPointPolitical();
                regUsers.ClickElementbotton();
                 MainPages mainPages = new MainPages();
                mainPages.AddParametrSearh(wait, критерииложПоиска, критерииПоиска, Text);
                mainPages.EnterSearhEnter();
                mainPages.Check();


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
