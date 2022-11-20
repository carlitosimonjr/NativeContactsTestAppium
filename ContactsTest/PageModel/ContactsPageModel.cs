using CognizantSoftvision.Maqs.BaseAppiumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace PageModel
{
    /// <summary>
    /// Page object for ContactsPageModel
    /// </summary>
    public class ContactsPageModel : BaseAppiumPageModel
    {
        /// <summary>
        /// The create new contact element 'By' finder
        /// </summary>
        private LazyMobileElement CreateNewContactIcon
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("com.android.contacts:id/floating_action_button"), "Create New Contact Icon"); }
        }

        /// <summary>
        /// The add account button element 'By' finder
        /// </summary>
        private LazyMobileElement AddAccountButton
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("com.android.contacts:id/right_button"), "Add Account Button"); }
        }

        /// <summary>
        /// The cancel button element 'By' finder
        /// </summary>
        private LazyMobileElement CancelButton
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("com.android.contacts:id/left_button"), "Cancel Button"); }
        }

        /// <summary>
        /// The favorite icont element 'By' finder
        /// </summary>
        private LazyMobileElement GetFavoriteIconByFullName(string fullname)
        {
            return this.GetLazyElement(By.XPath($"//android.widget.TextView[@text=\"{fullname}\"]//..//android.widget.ImageView[@content-desc=\"Favorites\"]"), "Favorite Icon");
        }

        private LazyMobileElement GetFullName(string fullname)
        {
            return this.GetLazyElement(By.XPath($"//android.widget.TextView[@text=\"{fullname}\"]"), "Contact Name");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The Appium test object</param>
        public ContactsPageModel(IAppiumTestObject testObject)
            : base(testObject)
        {
        }

        /// <summary>
        /// Clicks create new contact icon
        /// </summary>
        /// <returns></returns>
        public AddEditContactPageModel TapCreateNewContactIcon()
        {
            CreateNewContactIcon.Click();

            if (IsAddAccountDialogDisplayed())
            {
                CancelButton.Click();
            }

            return new AddEditContactPageModel(this.TestObject);
        }

        /// <summary>
        /// Verifies if add account dialog is displayed
        /// </summary>
        /// <returns> True if add account dialog exists, otherwise false </returns>
        public bool IsAddAccountDialogDisplayed()
        {
            return AddAccountButton.Exists;
        }

        /// <summary>
        /// Verifies if new contanct is set as favorite
        /// </summary>
        /// <param name="fullname"></param>
        /// <returns> True if new contact is set as favorite, otherwise false </returns>
        public bool IsNewContactSetAsFavorite(string fullname)
        {
            return GetFavoriteIconByFullName(fullname).Exists;
        }

        public bool IsNewContactDisplayed(string fullname)
        {
            return GetFullName(fullname).Exists;
        }

        /// <summary>
        /// Taps given contact name
        /// </summary>
        /// <param name="fullname"></param>
        public AddEditContactPageModel TapContactName(string fullname)
        {
            GetFullName(fullname).Click();
            return new AddEditContactPageModel(this.TestObject);
        }

        /// <summary>
        /// Check that the page is loaded
        /// </summary>
        /// <returns>True if the time is displayed</returns>
        public override bool IsPageLoaded()
        {
            return CreateNewContactIcon.Exists;
        }
    }
}
