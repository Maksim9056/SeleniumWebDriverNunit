using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public class Product
    {

        public string name = "Maksim";
        public string feelback = "#input-review";
       public string csselector ="#input-name";
        public const string Image = "div.product-thumb img";
        WebDriverWait wait;
        public string feedback =  "div.container:nth-child(4) div.row div.col-sm-12 div.row div.col-sm-8 ul.nav.nav-tabs li:nth-child(2) > a:nth-child(1)";
        public string Select1= "div.container:nth-child(4) div.row div.col-sm-9 div.row:nth-child(3) div.product-layout.product-grid.col-lg-4.col-md-4.col-sm-6.col-xs-12:nth-child(1) div.product-thumb div:nth-child(2) div.caption h4:nth-child(1) > a:nth-child(1)";
        public string Select ="div.container:nth-child(3) nav.navbar div.collapse.navbar-collapse.navbar-ex1-collapse ul.nav.navbar-nav li:nth-child(6) > a:nth-child(1)";
      public string Buybacked ="div.container:nth-child(4) div.row div.col-sm-9 div.row:nth-child(3) div.product-layout.product-grid.col-lg-4.col-md-4.col-sm-6.col-xs-12:nth-child(1) div.product-thumb div:nth-child(2) div.button-group > button:nth-child(1)";
        public void AddWebDriver(WebDriverWait waits)
        {
            wait = waits;
        }

        [Test]
        public void ImageClick( )
        {
            IWebElement imageElement = wait.Until(d => d.FindElement(By.CssSelector(Image)));

            // Нажать на изображение
            imageElement.Click();
        }

        [Test]
        public void SelectClick()
        {
            IWebElement imageElement = wait.Until(d => d.FindElement(By.CssSelector(Select)));

            // Нажать на изображение
            imageElement.Click();
             imageElement = wait.Until(d => d.FindElement(By.CssSelector(Buybacked)));
            imageElement.Click() ;
            imageElement = wait.Until(d => d.FindElement(By.CssSelector(Select1)));
            imageElement.Click();
            
           imageElement = wait.Until(d => d.FindElement(By.CssSelector(feedback)));
            imageElement.Click();
            imageElement = wait.Until(d => d.FindElement(By.CssSelector(csselector)));

            imageElement.SendKeys(name); 
           imageElement = wait.Until(d => d.FindElement(By.CssSelector(feelback)));

            imageElement.SendKeys("write review");
            

        }
    }
}
