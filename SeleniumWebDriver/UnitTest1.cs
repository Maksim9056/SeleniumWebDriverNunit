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
        public string ��������� = "� ������ ��������� ���";
        public string ������������������ = "� ������ ��������� ��� �������.";
        public string Name = "Maksim";
        public string FirstName = "��������";
        public string Mail = "testmaksimbc@mail.ru";
        public string PhoneNumbers = "+79226012118";
        public string Password = "1111";


        public string ����������������� = "��� �������, ������� ������������� ���������";
        public string �������������� = "��� �������, ������� ������������� ��������� ������.";
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
                // ����� ����������� (��������������, ��� � ����������� ���� ���������� ������� ��� �����)
                Product product = new Product();
                product.AddWebDriver(wait);
                product.ImageClick();
                driver.Navigate().Back();
                ���������� ���������� = new  ����������();
                ����������.AddWeb(wait, ���������, ������������������);
                ����������.Kategroy();
                ����������.FindClicPC();
                ����������.CheckKategory();
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
                mainPages.AddParametrSearh(wait, �����������������, ��������������, Text);
                mainPages.EnterSearhEnter();
                mainPages.Check();


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
