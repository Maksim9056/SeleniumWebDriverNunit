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
    [TestFixture]
    public class Tests
    {
     

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
                //Найти изображение(предполагается, что у изображения есть уникальный атрибут или класс)
                Product product = new Product();
                product.AddWebDriver(wait);
                product.ImageClick();
                driver.Navigate().Back();
                Компьютеры компьютеры = new Компьютеры();
                компьютеры.AddWeb(wait, категория, категориянастоящая);
                компьютеры.Kategroy();
                компьютеры.FindClicPC();
                компьютеры.CheckKategory();
                RegUsers regUsers = new RegUsers();
                regUsers.AddParametrRegUsers(wait, Name, FirstName, Mail, PhoneNumbers, Password);
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
                //mainPages.EnterSearhEnter();
                //mainPages.Check();
                mainPages.Aboutflippingthepage();
                mainPages.Addwishlist();
                mainPages.AddBucked();
                product.SelectClick();


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
    }

    
}
