using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/onepagecheckout");
            driver.FindElement(By.XPath("//img[@alt='Tricentis Demo Web Shop']")).Click();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            //driver.FindElement(By.LinkText("Log out")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("gender-male")).Click();
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("Ante");
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("Simurina");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("ante.simurina3211234@gmail.com");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("12345678");
            driver.FindElement(By.Id("ConfirmPassword")).Clear();
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("12345678");
            driver.FindElement(By.Id("register-button")).Click();
            
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.LinkText("Books")).Click();
            driver.FindElement(By.Id("products-orderby")).Click();
            new SelectElement(driver.FindElement(By.Id("products-orderby"))).SelectByText("Name: A to Z");
            driver.FindElement(By.Id("products-viewmode")).Click();
            new SelectElement(driver.FindElement(By.Id("products-viewmode"))).SelectByText("List");
            driver.FindElement(By.Id("products-orderby")).Click();
            new SelectElement(driver.FindElement(By.Id("products-orderby"))).SelectByText("Name: Z to A");
            driver.FindElement(By.Id("products-orderby")).Click();
            new SelectElement(driver.FindElement(By.Id("products-orderby"))).SelectByText("Price: Low to High");
            driver.FindElement(By.Id("products-viewmode")).Click();
            new SelectElement(driver.FindElement(By.Id("products-viewmode"))).SelectByText("Grid");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Filter by price'])[1]/following::span[1]")).Click();
            driver.FindElement(By.LinkText("Remove Filter")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Computing and Internet'])[1]/preceding::span[1]")).Click();
            driver.FindElement(By.LinkText("Remove Filter")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Computing and Internet'])[1]/preceding::span[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Books'])[5]/following::div[4]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Filter by price'])[1]/following::div[1]")).Click();
            driver.FindElement(By.LinkText("Remove Filter")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Electronics'])[3]/following::a[1]")).Click();
            driver.FindElement(By.Id("products-pagesize")).Click();
            new SelectElement(driver.FindElement(By.Id("products-pagesize"))).SelectByText("12");
            driver.FindElement(By.Id("products-orderby")).Click();
            new SelectElement(driver.FindElement(By.Id("products-orderby"))).SelectByText("Created on");
            driver.FindElement(By.Id("products-viewmode")).Click();
            new SelectElement(driver.FindElement(By.Id("products-viewmode"))).SelectByText("List");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Books'])[3]/following::a[1]")).Click();
            driver.FindElement(By.XPath("//img[@alt='Picture for category Desktops']")).Click();
            driver.FindElement(By.XPath("//div[6]/div/div[2]/div[3]/div[2]/input")).Click();
            driver.FindElement(By.Id("product_attribute_75_5_31_96")).Click();
            driver.FindElement(By.Id("add-to-cart-button-75")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Digital downloads'])[3]/following::a[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='From 350.00'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='From 350.00'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='From 350.00'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='From 350.00'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='From 350.00'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='From 350.00'])[1]/following::div[3]")).Click();
            driver.FindElement(By.LinkText("Diamond Tennis Bracelet")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Electronics'])[3]/following::a[1]")).Click();
            driver.FindElement(By.XPath("//div[4]/div/div[2]/div[3]/div[2]/input")).Click();
            driver.FindElement(By.XPath("//li[@id='topcartlink']/a/span")).Click();
            driver.FindElement(By.XPath("//tr[2]/td/input")).Click();
            driver.FindElement(By.Name("updatecart")).Click();
            driver.FindElement(By.Name("discountcouponcode")).Click();
            driver.FindElement(By.Name("discountcouponcode")).Clear();
            driver.FindElement(By.Name("discountcouponcode")).SendKeys("lijeposunce");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Enter your coupon here'])[1]/following::div[1]")).Click();
            driver.FindElement(By.Name("applydiscountcouponcode")).Click();
            driver.FindElement(By.Id("CountryId")).Click();
            new SelectElement(driver.FindElement(By.Id("CountryId"))).SelectByText("Cote D'Ivoire");
            driver.FindElement(By.Id("StateProvinceId")).Click();
            driver.FindElement(By.Id("ZipPostalCode")).Click();
            driver.FindElement(By.Id("ZipPostalCode")).Click();
            driver.FindElement(By.Id("ZipPostalCode")).Clear();
            driver.FindElement(By.Id("ZipPostalCode")).SendKeys("123123");
            driver.FindElement(By.Name("estimateshipping")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Zip / postal code:'])[1]/following::ul[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='The one day air shipping'])[1]/following::li[1]")).Click();
            driver.FindElement(By.Id("termsofservice")).Click();
            driver.FindElement(By.Id("checkout")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
