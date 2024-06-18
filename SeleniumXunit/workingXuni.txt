using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppsTest
{
    public class UnitTest1
    {
        [Fact]
        public void test_Creat_Product_form()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:50294/";
            driver.Navigate().GoToUrl("http://localhost:50294/Product/Create");
            driver.Manage().Window.Maximize();

            // IWebElement ap = driver.FindElement(By.Id("learn"));
            IWebElement FeedCreate = driver.FindElement(By.XPath("/html/body/div/h2"));
            string text = FeedCreate.Text;

            // String title = driver.Title;
            Assert.Equal("Create", text);

            System.Threading.Thread.Sleep(2000);
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }

        [Fact]
        public void testCreate()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:50294/";
            driver.Navigate().GoToUrl("http://localhost:50294/Product/Create");
            driver.Manage().Window.Maximize();

            // IWebElement ap = driver.FindElement(By.Id("learn"));
            IWebElement ProductNameTextbox = driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div/input"));
            ProductNameTextbox.Click();
            ProductNameTextbox.SendKeys("Orange");

            System.Threading.Thread.Sleep(2000);

            IWebElement PriceTextbox = driver.FindElement(By.XPath("/html/body/div/form/div/div[2]/div/input"));
            PriceTextbox.Click();
            PriceTextbox.SendKeys("2.0");

            System.Threading.Thread.Sleep(2000);

            IWebElement DescriptionTextbox = driver.FindElement(By.XPath("/html/body/div/form/div/div[3]/div/input"));
            DescriptionTextbox.Click();
            DescriptionTextbox.SendKeys("Juicy orange");

            System.Threading.Thread.Sleep(2000);

            IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/div/form/div/div[4]/div/input"));
            SubmitButton.Click();

            IWebElement IndexLabel = driver.FindElement(By.XPath("/html/body/div/h2"));
            string labelText = IndexLabel.Text;

            System.Threading.Thread.Sleep(2000);

            Assert.Equal("Index", labelText);

            System.Threading.Thread.Sleep(2000);
            // driver.Navigate().Back();
            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }

        // /html/body/div/table/tbody/tr[5]
        [Fact]
        public void test_Orange()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:50294/";
            driver.Navigate().GoToUrl("http://localhost:50294/Product");
            driver.Manage().Window.Maximize();

            // IWebElement ap = driver.FindElement(By.Id("learn"));
            IWebElement FeedCreate = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[1]"));
            string text = FeedCreate.Text;

            // String title = driver.Title;
            Assert.Equal("Orange", text);

            System.Threading.Thread.Sleep(2000);
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }

        [Fact]
        public void test_Orange_Price()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:50294/";
            driver.Navigate().GoToUrl("http://localhost:50294/Product");
            driver.Manage().Window.Maximize();

            // IWebElement ap = driver.FindElement(By.Id("learn"));
            IWebElement FeedCreate = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[2]"));
            string text = FeedCreate.Text;

            // String title = driver.Title;
            Assert.Equal("2.00", text);

            System.Threading.Thread.Sleep(2000);
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }
        [Fact]
        public void test_Orange_Desc()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:50294/";
            driver.Navigate().GoToUrl("http://localhost:50294/Product");
            driver.Manage().Window.Maximize();

            // IWebElement ap = driver.FindElement(By.Id("learn"));
            IWebElement FeedCreate = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[3]"));
            string text = FeedCreate.Text;

            // String title = driver.Title;
            Assert.Equal("Juicy orange", text);

            System.Threading.Thread.Sleep(2000);
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(5000);

            driver.Quit();
        }

    }
}