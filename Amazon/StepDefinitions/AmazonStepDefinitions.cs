using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

    }
}
