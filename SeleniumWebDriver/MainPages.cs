using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenQA.Selenium.Interactions;

namespace SeleniumWebDriver
{
    public class MainPages
    {
        WebDriverWait wait;
        public IWebElement Main;
        string критерииложПоиска;
        string критерииПоиска;
        string Test;
        public string Pagedownv = "body";
        public string callback = "div.container div.row div.col-sm-4 div:nth-child(1) > h1:nth-child(1)";
        public const string Buyipad = "#button-cart";
        public const string AddBUCKID = "#content > div.row > div:nth-child(4) > div > div.button-group > button:nth-child(1)";
        public const string Wichlist = "div.container:nth-child(4) div.row div.col-sm-12 div.row:nth-child(4) div.product-layout.col-lg-3.col-md-3.col-sm-6.col-xs-12:nth-child(2) div.product-thumb.transition div.button-group > button:nth-child(2)";
        public const string  AddIpad = "div.container:nth-child(4) div.row div.col-sm-12 div.swiper-viewport:nth-child(1) div.swiper-container.swiper-container-horizontal div.swiper-wrapper div.swiper-slide.text-center.swiper-slide-duplicate.swiper-slide-active:nth-child(4) a:nth-child(1) > img.img-responsive";
        public const string Csselectror = "div.container:nth-child(4) div.row div.col-sm-12 div.swiper-viewport:nth-child(1) div.swiper-container.swiper-container-horizontal div.swiper-wrapper div.swiper-slide.text-center.swiper-slide-prev.swiper-slide-duplicate-next:nth-child(3) > img.img-responsive";
        public const string строкапоиска = "/html/body/header/div/div/div[2]/div/input";
        public string Maim ="#logo > h1 > a";
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
            Main = wait.Until(d => d.FindElement(By.CssSelector(Maim)));
            Main.Click();
        }

        [Test]
        public void Aboutflippingthepage()
        {
            Main = wait.Until(d => d.FindElement(By.CssSelector(Csselectror)));
            Main.Click();

            Main.Click();

            Main.Click();

            //Assert.IsTrue(Main.Text == критерииПоиска);
        }
        [Test]
        public void Addwishlist()
        {
            Main = wait.Until(d => d.FindElement(By.CssSelector(Wichlist)));
            Main.Click();
        }
        [Test]
        public void AddBucked()
        {

            Main = wait.Until(d => d.FindElement(By.CssSelector(Pagedownv)));
            Main.SendKeys(Keys.Space);

            Main = wait.Until(d => d.FindElement(By.CssSelector(AddBUCKID)));


          
            Main.Click();
        }

        [Test]
        public void AddIpads()
        {
            Main = wait.Until(d => d.FindElement(By.CssSelector(AddIpad)));
            Main.Click();
            Main = wait.Until(d => d.FindElement(By.CssSelector(Buyipad)));
            Main.Click() ;
            
            Main = wait.Until(d => d.FindElement(By.CssSelector(callback)));
            Main.Click();

        }


    }
}
