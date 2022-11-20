using CognizantSoftvision.Maqs.BaseAppiumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace PageModel
{
    /// <summary>
    /// Page object for ContactDetailsPageModel
    /// </summary>
    public class ContactDetailsPageModel : BaseAppiumPageModel
    {
        /// <summary>
        /// The user name input element 'By' finder
        /// </summary>
        private LazyMobileElement EditContactIcon
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("com.android.contacts:id/menu_edit"), "Edit Contact Icon"); }
        }

        /// <summary>
        /// The password input element 'By' finder
        /// </summary>
        private LazyMobileElement FavoriteIcon
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("com.android.contacts:id/menu_star"), "Favorite Icon"); }
        }

        /// <summary>
        /// The login button element 'By' finder
        /// </summary>
        private LazyMobileElement LoginButton
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("Login"), "Login Button"); }
        }

        private LazyMobileElement CompanyName
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout[1]/android.widget.ScrollView/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.TextView[2]"), "Company Name"); }
        }

        private LazyMobileElement GetCompanyName(string companyName)
        {
            return this.GetLazyElement(By.XPath($"/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout[1]/android.widget.ScrollView/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.TextView[@text=\"{companyName}\"]"), "Company Name");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetailsPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The Appium test object</param>
        public ContactDetailsPageModel(IAppiumTestObject testObject)
            : base(testObject)
        {
        }

        /// <summary>
        /// Taps edit contact icon
        /// </summary>
        public void TapEditContactIcon()
        {
            EditContactIcon.Click();
        }

        /// <summary>
        /// Taps favorite icon
        /// </summary>
        public void TapFavoriteIcon()
        {
            FavoriteIcon.Click();
        }

        /// <summary>
        /// Taps back button
        /// </summary>
        public ContactsPageModel TapBackButton()
        {
            this.TestObject.AppiumDriver.Navigate().Back();
            return new ContactsPageModel(this.TestObject);
        }

        public bool IsCompanyReflectedAsOrganization(string companyName)
        {
            return GetCompanyName(companyName).Exists;
        }

        /// <summary>
        /// Check that the page is loaded
        /// </summary>
        /// <returns>True if the time is displayed</returns>
        public override bool IsPageLoaded()
        {
            return LoginButton.Exists;
        }
    }
}
