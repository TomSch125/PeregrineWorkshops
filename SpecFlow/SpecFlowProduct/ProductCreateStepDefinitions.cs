using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpecFlowProduct
{
    [Binding]
    public class ProductCreateStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"I am on the add product screen")]
        public void GivenIAmOnTheAddProductScreen()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:50294";
            driver.Navigate().GoToUrl("http://localhost:50294/Product/Create");

        }

        [Given(@"I enter a product name of lemonaid")]
        public void GivenIEnterAProductNameOfLemonaid()
        {
            IWebElement ProductNameTextbox = driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div/input"));
            ProductNameTextbox.Click();
            ProductNameTextbox.SendKeys("lemonaid");
        }

        [Given(@"I enter a price of (.*)")]
        public void GivenIEnterAPriceOf(Decimal p0)
        {
            IWebElement PriceTextbox = driver.FindElement(By.XPath("/html/body/div/form/div/div[2]/div/input"));
            PriceTextbox.Click();
            PriceTextbox.SendKeys("3.50");
        }

        [Given(@"I enter a desciption of ""([^""]*)""")]
        public void GivenIEnterADesciptionOf(string p0)
        {
            IWebElement DescriptionTextbox = driver.FindElement(By.XPath("/html/body/div/form/div/div[3]/div/input"));
            DescriptionTextbox.Click();
            DescriptionTextbox.SendKeys("1 Litre Bottle");
        }

        [When(@"I sumbit my product")]
        public void WhenISumbitMyProduct()
        {
            IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/div/form/div/div[4]/div/input"));
            SubmitButton.Click();
        }

        [Then(@"I should see the new product in the list of products")]
        public void ThenIShouldSeeTheNewProductInTheListOfProducts()
        {

            IWebElement IndexLabel = driver.FindElement(By.XPath("/html/body/div/h2"));
            string labelText = IndexLabel.Text;


            Assert.Equal("Index", labelText);

            //driver.Navigate().GoToUrl("http://localhost:50294/Product");
            //driver.Manage().Window.Maximize();

            //IWebElement FeedCreate = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr[5]/td[1]"));
            //string text = FeedCreate.Text;

            //Assert.Equal("lemonaid", text);

            driver.Quit();
        }
    }
}
