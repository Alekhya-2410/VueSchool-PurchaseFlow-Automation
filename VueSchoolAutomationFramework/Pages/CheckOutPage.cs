using OpenQA.Selenium;
using VueSchoolAutomationFramework.ObjectRepos;
using VueSchoolAutomationFramework.Utilities;

namespace VueSchoolAutomationFramework.Pages
{
    public class CheckOutPage
    {
        private IWebDriver driver;
        private CheckOutRepo checkOutRepo;
        private ActionHelpers actionHelpers;

        public CheckOutPage(IWebDriver driver)
        {
            this.driver = driver;
            checkOutRepo = new CheckOutRepo(driver);
            actionHelpers = new ActionHelpers();
        }

        public void ScrollToProceesToPaymentButton()
        {
            actionHelpers.ScrollToCenter(checkOutRepo.GetProceedToPaymentButton(), driver);
            Thread.Sleep(2000);
        }
    }
}
