using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;


namespace TestExample.TestStepDefinitions
{
    [Binding]
    public class LibraryTestsStepDefinitions : TestStepDefinitionBase
    {
        public LibraryTestsStepDefinitions() : base() { }

        [When("Tab (.*) is opened")]
        public void TabOpened(string tabName)
        {
            WorldPhenomenaPageDefinition.CommunicationButton.Click();
            WorldPhenomenaPageDefinition.ResourceTab(tabName).Click();
        }

        [Then("(.*) elements appear with the last resource (.*)")]
        public void ThenElementsAppear(int numerOfElements, string lastResourceName)
        {
            WorldPhenomenaPageDefinition.WaitFor(WorldPhenomenaPageDefinition.Resources.First(), 5000);
            WorldPhenomenaPageDefinition.ScrollResourcesTo(lastResourceName);
            int number = WorldPhenomenaPageDefinition.Resources.Count();
            Assert.That(Equals(number, numerOfElements));
        }

        [Then("Resource (.*) type is (.*)")]
        public void ThenResourceTypeIs(string resourceName, string typeName)
        {
            var resource = WorldPhenomenaPageDefinition.WaitFor(WorldPhenomenaPageDefinition.Resource(resourceName), 1000);
            string type = WorldPhenomenaPageDefinition.ResourceType(resource);

            Assert.That(type.Contains(typeName));
        }
    }
}
