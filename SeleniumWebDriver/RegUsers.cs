using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumWebDriver
{
    public class RegUsers
    {
        public WebDriverWait wait;
        public IWebElement Reguser;

        public string Name;
        public string FirstName;
        public string Mail;
        public string PhoneNumbers;
        public string Password;



        public const string Elements = "/html/body/nav/div/div/ul/li[2]/a";
        public const string ElementsTravels = "/html/body/nav/div/div/ul/li[2]/ul/li[1]/a";
        public const string ElementName = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[2]/div[1]/input[1]";
        public const string ElementFirstName = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[3]/div[1]/input[1]";
        public const string ElementMail = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[4]/div[1]/input[1]";
        public const string ElementPhoneNumbers = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/input[1]";
        public const string ElementPassword = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[2]/div[1]/div[1]/input[1]";
        public const string ElementPassword1 = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[2]/div[2]/div[1]/input[1]";
        public const string ElementPoint = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/fieldset[3]/div[1]/div[1]/label[2]";
        public const string ElementPointCheckV = "/html/body/div[2]/div/div/form/div/div/input[1]";
        public const string ElementPointPolitical = "/html/body/div[2]/div[2]/div/form/div/div/input[2]";
        public const string Elementbotton = "/html/body/header/div/div/div[1]/div/h1/a";


        public void AddParametrRegUsers(WebDriverWait waits, string Name1, string FirstName1, string Mail1, string PhoneNumbers1, string Password1)
        {
            wait = waits;
            Name = Name1;
            FirstName = FirstName1;
            Mail = Mail1;
            PhoneNumbers = PhoneNumbers1;
            Password = Password1;

        }

        public void RegUserStart()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(Elements)));
            Reguser.SendKeys(Keys.Enter);
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementsTravels)));
            Reguser.SendKeys(Keys.Enter);
        }
        [Test]

        public void EnterName()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementName)));
            Reguser.SendKeys(Name);
        }
        [Test]

        public void EnterFirstName()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementFirstName)));
            Reguser.SendKeys(FirstName);
        }
        [Test]

        public void EnterMail()
        {

            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementMail)));
            Reguser.SendKeys(Mail);
        }
        [Test]

        public void EnterPhoneNumbers()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementPhoneNumbers)));
            Reguser.SendKeys(PhoneNumbers);
        }
        [Test]

        public void EnterPassword()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementPassword)));
            Reguser.SendKeys(Password);

        }
        [Test]

        public void EnterRepeatPassword()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementPassword1)));
            Reguser.SendKeys(Password);
        }

        [Test]
        public void ClickPoint()
        {

            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementPoint)));
            Reguser.SendKeys(Keys.Enter);

        }
        [Test]
        public void ClicklointCheckV()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementPointCheckV)));
            Reguser.Click();
        }
        [Test]

        public void ClickPointPolitical()
        {
            Reguser = wait.Until(d => d.FindElement(By.XPath(ElementPointPolitical)));
            Reguser.Click();
        }
        [Test]
        public void ClickElementbotton()
        {

            Reguser = wait.Until(d => d.FindElement(By.XPath(Elementbotton)));
            Reguser.Click();
        }
    }
}