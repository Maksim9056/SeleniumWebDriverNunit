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
        public const string Image = "div.product-thumb img";
        WebDriverWait wait;
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
    }
}
