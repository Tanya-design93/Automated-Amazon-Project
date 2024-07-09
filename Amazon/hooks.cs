using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Amazon
{
    [Binding]
    public sealed class hooks
    {

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        readonly IWebDriver driver = new ChromeDriver();


        [BeforeScenario(Order = 1)]
        public void SetupDriver(ScenarioContext _scenarioContext)
        {
            // Initialize your driver (e.g., WebDriver or other test context).
            // Save it to the ScenarioContext.
            _scenarioContext["Driver"] = driver;
        }


        [BeforeScenario(Order = 2)]
        public void BeforeScenarioWithTag()
        {
            driver.Navigate().GoToUrl("https://www.amazon.ca");
        }
    }
}