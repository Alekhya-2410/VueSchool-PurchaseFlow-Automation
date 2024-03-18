using OpenQA.Selenium;
using VueSchoolAutomationFramework.ObjectRepos;
using VueSchoolAutomationFramework.Utilities;

namespace VueSchoolAutomationFramework.Pages
{
    public class PricingWorkFlowPage
    {
        private IWebDriver driver;
        private PricingWorkFlowRepo pricingWorklowRepo;
        private ActionHelpers actionHelpers;

        public PricingWorkFlowPage(IWebDriver driver)
        {
            this.driver = driver;
            pricingWorklowRepo = new PricingWorkFlowRepo(driver);
            actionHelpers = new ActionHelpers();
        }

        public void ScrollToMasteringNuxt3CompleteBundle()
        {
            actionHelpers.ScrollToCenter(pricingWorklowRepo.GetMasteringNuxt3Complete(), driver);
            Thread.Sleep(3000);
        }

        public void ScrollToVueSchoolLifeTimeSubscriptionBundle()
        {
            actionHelpers.ScrollToCenter(pricingWorklowRepo.GetVueSchoolLifeTimeSubscription(), driver);
            Thread.Sleep(1000);
        }

        public void ScrollToMasteringPiniaCompleteBundle()
        {
            actionHelpers.ScrollToCenter(pricingWorklowRepo.GetMasteringPiniaComplete(), driver);
            Thread.Sleep(3000);
        }
        public void ScrollToActivateSADiscount()
        {
            actionHelpers.ScrollToCenter(pricingWorklowRepo.GetActivateSADiscountCheckBox(), driver);
            Thread.Sleep(3000);
        }

        public void AddBundlesIntoCart()
        {
            actionHelpers.ClickObject(pricingWorklowRepo.GetMasteringNuxt3Complete(), driver);
            actionHelpers.ClickObject(pricingWorklowRepo.GetCloseBundleCartButton(), driver);
            Thread.Sleep(3000);

            ScrollToVueSchoolLifeTimeSubscriptionBundle();
            actionHelpers.ClickObject(pricingWorklowRepo.GetVueSchoolLifeTimeSubscription(), driver);
            actionHelpers.ClickObject(pricingWorklowRepo.GetCloseBundleCartButton(), driver);
            Thread.Sleep(1000);

            ScrollToMasteringPiniaCompleteBundle();
            actionHelpers.ClickObject(pricingWorklowRepo.GetMasteringPiniaComplete(), driver);
            Thread.Sleep(3000);
        }

        public void ClickReviewOrderButton()
        {
            actionHelpers.ClickObject(pricingWorklowRepo.GetReviewOrderButton(), driver);
        }

        public void ClickActivateSADiscountCheckBox()
        {
            ScrollToActivateSADiscount();
            Thread.Sleep(5000);
            actionHelpers.ClickObject(pricingWorklowRepo.GetActivateSADiscountCheckBox(), driver);
        }
    }
}
