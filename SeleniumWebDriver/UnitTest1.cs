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
                //����� �����������(��������������, ��� � ����������� ���� ���������� ������� ��� �����)
                Product product = new Product();
                product.AddWebDriver(wait);
                product.ImageClick();
                driver.Navigate().Back();
                ���������� ���������� = new ����������();
                ����������.AddWeb(wait, ���������, ������������������);
                ����������.Kategroy();
                ����������.FindClicPC();
                ����������.CheckKategory();
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
                mainPages.AddParametrSearh(wait, �����������������, ��������������, Text);
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
                // �������� �����������

                driver.Quit();
            }
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
    }

    
}
