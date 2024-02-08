using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumWebDriver
{

    public class Компьютеры
    {
        public WebDriverWait wait;
        public IWebElement searchBox;

        public string категория;
        public string категориянастоящая;

        public const string компьютеры = "/html/body/div[1]/nav/div[2]/ul/li[1]/a";
        public const string Pc = "div.container:nth-child(3) nav.navbar div.collapse.navbar-collapse.navbar-ex1-collapse ul.nav.navbar-nav li.dropdown:nth-child(1) div.dropdown-menu div.dropdown-inner ul.list-unstyled li:nth-child(1) > a:nth-child(1)";
        public const string проверка = "body:nth-child(2) div.container:nth-child(4) div.row div.col-sm-9 > p:nth-child(2)";
        public void AddWeb(WebDriverWait waits, string категория1, string категориянастоящая2)
        {
            wait = waits;
            категория = категория1;
            категориянастоящая = категориянастоящая2;
        }

  
        [Test]
        public void Kategroy()
        {
            searchBox = wait.Until(d => d.FindElement(By.XPath(компьютеры)));
            searchBox.SendKeys(Keys.Enter);
        }

        [Test]
        public void FindClicPC()
        {
            searchBox = wait.Until(d => d.FindElement(By.CssSelector(Pc)));
            searchBox.SendKeys(Keys.Enter);
        }
        [Test]
        public void CheckKategory()
        {
            searchBox = wait.Until(d => d.FindElement(By.CssSelector(проверка)));
            bool i = searchBox.Text == категория;
            Assert.IsTrue(searchBox.Text == категориянастоящая);
        }

    }
}
