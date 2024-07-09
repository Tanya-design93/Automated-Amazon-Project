using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Amazon.StepDefinitions
{
    [Binding]
    public sealed class AmazonStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver driver;

        public AmazonStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = (IWebDriver)_scenarioContext["Driver"];
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
            Assert.That(driver.PageSource.Should().NotContain("No results for"), Is.False, "There were no results found for the given search.");
        }

        [When(@"a user scrolls down to the needed item")]
        public void WhenAUserScrollsDownToTheNeededItem()
        {
            By redkenLocator = By.XPath("//span[contains(text(),'Redken Shampoo, Volume')]");

            Assert.That(driver.FindElement(redkenLocator), Is.True, "The Redken Shampoo Option is not visible");
            // Locate the item using CSS selector for the class names
            IWebElement item = driver.FindElement(redkenLocator);

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
        public void WhenTheUserClicksTheButton()
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

        [Given(@"clicks on the home button on the home tab")]
        public void GivenClicksOnTheHomeButtonOnTheHomeTab()
        {
            IWebElement homeButton = driver.FindElement(By.LinkText("Home"));
            homeButton.Click();
        }

        [When(@"the user clicks on the vacuums")]
        public void WhenTheUserClicksOnTheVacuums()
        {
            IWebElement secondItem = driver.FindElement(By.LinkText("Vacuums"));
            secondItem.Click();
        }

        [When(@"a user clicks on the carpet option")]
        public void WhenAUserClicksOnTheCarpetOption()
        {

            IWebElement carpetCheckbox = driver.FindElement(By.LinkText("Carpet"));
            carpetCheckbox.Click();

        }

        [When(@"clicks on the first item that appears")]
        public void WhenClicksOnTheFirstItemThatAppears()
        {

            IWebElement vacuum = driver.FindElement(By.PartialLinkText("dreame L20"));
            vacuum.Click();
        }

        [Then(@"the item should be a vacuum")]
        public void ThenTheItemShouldBeAVacuum()
        {

            IWebElement productTitle = driver.FindElement(By.Id("productTitle"));
            productTitle.Click();
        }

    }

}
