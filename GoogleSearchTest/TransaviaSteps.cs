using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using System;
using System.Threading;

namespace Transavia

{
    [Binding]
    public class TransaviaSteps
    {
        private const string transaviaURL = @"https://www.transavia.com/nl-NL/";
        private IWebDriver driver;


        public TransaviaSteps()
        {
            var service = ChromeDriverService.CreateDefaultService();
            var options = new ChromeOptions();
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                service.HideCommandPromptWindow = true;
                options.AddArgument("headless");
            }

            driver = new ChromeDriver(service, options);
            driver.Manage().Window.Maximize();
        }

        [Given(@"a user is on the Transavia.com homepage")]
        public void AuserisontheTransaviacomhomepage()
        {
            //Go to Transavia URL, wait 15 seconds to allow manual confirm Cookies and pass the Captcha Test
            driver.Url = transaviaURL;
            driver.Navigate();
            Thread.Sleep(15000);
        }


        [When(@"the user clicks on Bestemmingen in Secondary Menu")]
        public void WhenTheUserClicksOnBestemmingenInSecondaryMenu()
        {
            //Find Link containing "Bestemmingen" inside the Secondary Navigation.
            driver.FindElement(By.XPath("//div[contains(@class,'secondary-navigation')]")).FindElement(By.LinkText("Bestemmingen")).Click();
        }
        

        [When(@"the user fills the field ""(.*)"" with ""(.*)""")]
        public void WhenTheUserFillsTheFieldWith(string field, string text)
        {
            //wait 15 seconds to allow manual confirm Cookies and pass the Captcha Test
            Thread.Sleep(15000);
            //Find Email Address Subscription Field, Clear it and type the Test E-mail Address
            driver.FindElement(By.Id("newsletterSubscription_EmailAddress")).Click();
            driver.FindElement(By.Id("newsletterSubscription_EmailAddress")).Clear();
            driver.FindElement(By.Id("newsletterSubscription_EmailAddress")).SendKeys(text);
        }


        [When(@"the user clicks on Aanmelden")]
        public void WhenTheUserClicksOn()
        {
            //Click on the "Aanmelden" button
            driver.FindElement(By.Id("newsletter-subscription")).FindElement(By.XPath("//button[@class='button button-secondary']")).Click();
        }



        [Then(@"the user sees a confirmation of registration")]
        public void theuserseesaconfirmationofregistration()
        {
            String message = "We hebben een e-mail naar je gestuurd om de inschrijving voor onze nieuwsbrief te bevestigen.";
            //Wait on Loading Animation
            Thread.Sleep(3000);
            //Assert presence of Success Notification and check Message
            Assert.AreEqual(true, driver.FindElement(By.XPath("//div[contains(@class,'notification-success')]")).Displayed);
            driver.FindElement(By.ClassName("notification-message notification-inline notification-success is-visible-block")).GetAttribute("OuterHTML").Equals(message);
        }


        [When(@"the user searches for a flight for 1 Volwassene Leaving from ""(.*)"" To ""(.*)"" on ""(.*)"" and back on ""(.*)""")]
        public void WhenTheUserSearchesForAFlightForOneAdultsLeavingFromToOnAndBackOn(string Departure, string Arrival, string OutboundDate, string ReturnFlightDate)
        {            
            //Fill in ARRIVAL field
            driver.FindElement(By.Id("routeSelection_ArrivalStation-input")).Click();
            driver.FindElement(By.Id("routeSelection_ArrivalStation-input")).Clear();
            driver.FindElement(By.Id("routeSelection_ArrivalStation-input")).SendKeys(Arrival);

            //Fill in LEAVING ON field
            driver.FindElement(By.Id("dateSelection_OutboundDate-datepicker")).Click();
            driver.FindElement(By.Id("dateSelection_OutboundDate-datepicker")).Clear();
            driver.FindElement(By.Id("dateSelection_OutboundDate-datepicker")).SendKeys(OutboundDate);

            //Fill in BACK ON field
            driver.FindElement(By.Id("dateSelection_IsReturnFlight-datepicker")).Click();
            driver.FindElement(By.Id("dateSelection_IsReturnFlight-datepicker")).Clear();
            driver.FindElement(By.Id("dateSelection_IsReturnFlight-datepicker")).SendKeys(ReturnFlightDate);

            //Fill in DEPARTURE field
            driver.FindElement(By.Id("routeSelection_DepartureStation-input")).Click();
            driver.FindElement(By.Id("routeSelection_DepartureStation-input")).Clear();
            driver.FindElement(By.Id("routeSelection_DepartureStation-input")).SendKeys(Departure);
        }


        [Then(@"the user sees the page with the title ""(.*)""")]
        public void ThenTheUserSeesThePageWithTheTitle(string Title)
        {
            // Assert Page Title to be the same as String
            Assert.AreEqual(Title, driver.Title);
        }


        [Then(@"the user can see Search Results")]
        public void ThenTheUserCanSeeSearchResults()
        {
            Assert.AreEqual(true, driver.FindElement(By.XPath("//div[contains(@class,'c-flight-results-panel')]")).Displayed);
            // False Assertion doesn't work yet...
            //Assert.AreEqual(false, driver.FindElement(By.XPath("//div[contains(@class,'notification-error')]")).Displayed;
        }


        [AfterScenario]
        public void TearDown()
        {
            driver?.Close();
        }
    }
}
