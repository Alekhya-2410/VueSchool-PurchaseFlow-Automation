using OpenQA.Selenium;
using VueSchoolAutomationFramework.Pages;
using VueSchoolAutomationFramework.Utilities;

namespace VueSchoolAutomationFramework.StepDefinitions
{
    [Binding]
    public class VerifyingThePricingWorkFlowOnVuebundleStepDefinitions
    {
        private IWebDriver driver;
        private PricingWorkFlowPage pricingWorkFlowPage;
        private CheckOutPage checkOutPage;
        public VerifyingThePricingWorkFlowOnVuebundleStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            pricingWorkFlowPage = new PricingWorkFlowPage(driver);
            checkOutPage = new CheckOutPage(driver);
        }


        [Given(@"a user launches the Vuebundle application to purchase bundles")]
        public void GivenAUserLaunchesTheVuebundleApplicationToPurchaseBundles()
        {
            driver.Url = GlobalVariables.URL;
            Thread.Sleep(5000);
        }

        [When(@"user is on home page and navigates to build your own Vue bundle")]
        public void WhenUserIsOnHomePageAndNavigatesToBuildYourOwnVueBundle()
        {
            pricingWorkFlowPage.ScrollToMasteringNuxt3CompleteBundle();
        }

        [When(@"user adds the multiple bundles into cart and click on review order")]
        public void WhenUserAddsTheMultipleBundlesIntoCartAndClickOnReviewOrder()
        {
            pricingWorkFlowPage.AddBundlesIntoCart();
            pricingWorkFlowPage.ClickReviewOrderButton();
        }

        [Then(@"user verifies the total amount and unlocked additional discount in the review order")]
        public void ThenUserVerifiesTheTotalAmountAndUnlockedAdditionalDiscountInTheReviewOrder()
        {
            Thread.Sleep(2000);
            checkOutPage.ScrollToProceesToPaymentButton();
        }

        [When(@"user navigates to we support developers from South Africa and click on activate twenty percent discount")]
        public void WhenUserNavigatesToWeSupportDevelopersFromSouthAfricaAndClickOnActivateTwentyPercentDiscount()
        {
            pricingWorkFlowPage.ClickActivateSADiscountCheckBox();
            Thread.Sleep(2000);
        }

    }
}

