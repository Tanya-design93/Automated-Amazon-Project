using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Amazon.StepDefinitions
{
    [Binding]
    public sealed class AmazonStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"user navigates to Amazon\.ca")]
        public void GivenUserNavigatesToAmazon_Ca()
        {
            driver.Navigate().GoToUrl("https://amazon.ca");
        }

        [Given(@"user types shampoo in the search bar")]
        public void GivenUserTypesShampooInTheSearchBar()
        {
            IWebElement searchBar = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBar.SendKeys("Shampoo");
        }

        [When(@"the user preses the search button")]
        public void WhenTheUserPresesTheSearchButton()
        {
            IWebElement searchBarButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchBarButton.Click();

        }

        [Then(@"some results should appear")]
        public void ThenSomeResultsShouldAppear()
        {
            driver.PageSource.Should().NotContain("No results for");
        }

        [When(@"a user scrolls down to the needed item")]
        public void WhenAUserScrollsDownToTheNeededItem()
        {
            // Locate the item using CSS selector for the class names
            IWebElement item = driver.FindElement(By.XPath("//span[contains(text(),'Redken Shampoo, Volume')]"));

            // Initialize Actions class
            Actions actions = new(driver);

            // Move to the item and click it
            actions.MoveToElement(item).Perform();

        }


        [When(@"the user clicks on the item")]
        public void WhenTheUserClicksOnTheItem()
        {
            IWebElement item = driver.FindElement(By.XPath("//span[contains(text(),'Redken Shampoo, Volume')]"));
            item.Click();

        }
        [When(@"the user clicks the ""([^""]*)"" button")]
        public void WhenTheUserClicksTheButton(string p0)
        {
            IWebElement cartButton = driver.FindElement(By.Id("add-to-cart-button"));
            cartButton.Click();
        }

        [Then(@"the item should be added to the cart")]
        public void ThenTheItemShouldBeAddedToTheCart()
        {
            IWebElement navigateCart = driver.FindElement(By.Id("sw-gtc"));
            navigateCart.Click();
        }

    }
}
