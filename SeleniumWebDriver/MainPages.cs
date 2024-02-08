using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SeleniumWebDriver
{
    public class MainPages
    {
        WebDriverWait wait;
        public IWebElement Main;
        string критерииложПоиска;
        string критерииПоиска;
        string Test;
        public const string строкапоиска = "/html/body/header/div/div/div[2]/div/input";

        public const string Другаястраница = "/html/body/div[2]/div/div/p[2]";
        public void AddParametrSearh(WebDriverWait waits, string критерииложПоиска1, string критерииПоиска1, string Test1)
        {
            wait = waits;
            критерииложПоиска = критерииложПоиска1;
            критерииПоиска = критерииПоиска1;
            Test = Test1;
        }

        [Test]
        public void EnterSearhEnter()
        {

            Main = wait.Until(d => d.FindElement(By.XPath(строкапоиска)));
            Main.SendKeys(Test);
            Main.SendKeys(Keys.Enter);
        }

        [Test]

        public void Check()
        {
            Main = wait.Until(d => d.FindElement(By.XPath(Другаястраница)));
            bool a = Main.Text == критерииложПоиска;
            Assert.IsTrue(Main.Text == критерииПоиска);
        }
    }
}
