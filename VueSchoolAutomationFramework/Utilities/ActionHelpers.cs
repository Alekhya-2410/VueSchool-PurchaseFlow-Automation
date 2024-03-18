using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VueSchoolAutomationFramework.Utilities
{
    public class ActionHelpers
    {
        public void ClickObject(By sElement, IWebDriver driver)
        {
            try
            {
                WaitForElementClickable(sElement, driver);
                driver.FindElement(sElement).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to click object " + e.Message);
            }
        }

        public void ScrollToTop(By sElement, IWebDriver driver)
        {
            WaitForElementClickable(sElement, driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(sElement));
        }

        public void ScrollToCenter(By sElement, IWebDriver driver)
        {
            WaitForElementClickable(sElement, driver);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView({ behavior: 'auto', block: 'center', inline: 'center' });", driver.FindElement(sElement));
        }

        public void WaitForElementClickable(By sElement, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(sElement));
        }
    }
}
