using OpenQA.Selenium;

namespace VueSchoolAutomationFramework.ObjectRepos
{
    public class CheckOutRepo
    {
        private IWebDriver driver;
        public CheckOutRepo(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Buttons
        public By GetProceedToPaymentButton()
        {
            return By.XPath("//p[contains(text(),'Total')]");
        }
        #endregion
    }
}
