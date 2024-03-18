using OpenQA.Selenium;

namespace VueSchoolAutomationFramework.ObjectRepos
{
    public class PricingWorkFlowRepo
    {
        private IWebDriver driver;
        public PricingWorkFlowRepo(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Buttons
        public By GetReviewOrderButton()
        {
            return By.XPath("//a[contains(text(),'Review Order')]");
        }

        public By GetCloseBundleCartButton()
        {
            return By.XPath("//*[@class ='h-7 w-7 text-perisian-rose hover:text-blue-violet']");
        }

        public By GetVueSchoolLifeTimeSubscription()
        {
            return By.XPath("(//button[contains(.,'Add')])[1]");
        }
        public By GetMasteringPiniaComplete()
        {
            return By.XPath("(//button[contains(.,'Add')])[2]");
        }
        public By GetMasteringNuxt3Complete()
        {
            return By.XPath("(//button[contains(.,'Add')])[3]");
        }

        public By GetOfficialVueCertificationExamPreparation()
        {
            return By.XPath("(//button[contains(.,'Add')])[4]");
        }

        public By GetMasteringNuxt2Complete()
        {
            return By.XPath("(//button[contains(.,'Add')])[7]");
        }

        #endregion

        #region CheckBox
        public By GetActivateSADiscountCheckBox()
        {
            return By.XPath("//input[@id='pppInterested']");
        }
        #endregion
    }
}
