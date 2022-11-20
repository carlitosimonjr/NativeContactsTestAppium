using CognizantSoftvision.Maqs.BaseAppiumTest;
using CognizantSoftvision.Maqs.Utilities.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PageModel
{
    /// <summary>
    /// Page object for AddNewContactPageModel
    /// </summary>
    public class AddEditContactPageModel : BaseAppiumPageModel
    {
        /// <summary>
        /// The first name input element 'By' finder
        /// </summary>
        private LazyMobileElement FirstNameInput
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText[1]"), "First Name Input"); }
        }

        /// <summary>
        /// The last name input element 'By' finder
        /// </summary>
        private LazyMobileElement LastNameInput
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText[2]"), "Last Name Input"); }
        }

        /// <summary>
        /// The phone number input element 'By' finder
        /// </summary>
        private LazyMobileElement PhoneNumberInput
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText"), "Phone Number Input"); }
        }

        /// <summary>
        /// The phone category dropdown element 'By' finder
        /// </summary>
        private LazyMobileElement PhoneCategoryDropdown
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("//android.widget.Spinner[@content-desc=\"Phone\"]/android.widget.TextView"), "Phone Category Dropdown"); }
        }

        /// <summary>
        /// The phone category dropdown menu element 'By' finder
        /// </summary>
        private LazyMobileElement PhoneCategoryDropdownMenu
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView"), "Phone Category Dropdown Menu"); }
        }

        /// <summary>
        /// The phone category dropdown options element 'By' finder
        /// </summary>
        private IEnumerable<AppiumElement> PhoneCategoryDropdownOptions
        {
            get { return this.TestObject.AppiumDriver.FindElements(By.XPath("//android.widget.CheckedTextView")); }
        }

        /// <summary>
        /// The email input element 'By' finder
        /// </summary>
        private LazyMobileElement EmailInput
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[3]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText"), "Email Input"); }
        }

        /// <summary>
        /// The save button element 'By' finder
        /// </summary>
        private LazyMobileElement SaveButton
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("com.android.contacts:id/editor_menu_save_button"), "Save Button"); }
        }

        /// <summary>
        /// The more field link element 'By' finder
        /// </summary>
        private LazyMobileElement MoreFieldLink
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.widget.TextView"), "More Fields Link"); }
        }

        /// <summary>
        /// The company name input element 'By' finder
        /// </summary>
        private LazyMobileElement CompanyNameInput
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[3]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText"), "Company Name Input"); }
        }

        /// <summary>
        /// The phone icon element 'By' finder
        /// </summary>
        private LazyMobileElement PhoneIcon
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("//android.widget.ImageView[@content-desc=\"Phone\"]"), "Phone Icon"); }
        }

        /// <summary>
        /// The person icon element 'By' finder
        /// </summary>
        private LazyMobileElement PersonIcon
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("//android.widget.ImageView[@content-desc=\"Name\"]"), "Person Icon"); }
        }

        /// <summary>
        /// The more options icon element 'By' finder
        /// </summary>
        private LazyMobileElement MoreOptionsIcon
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("//android.widget.ImageButton[@content-desc=\"More options\"]"), "More Options Icon"); }
        }

        private LazyMobileElement DeleteOption
        {
            get { return new LazyMobileElement(this.TestObject, By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.TextView"), "Delete Option"); }
        }

        private LazyMobileElement DeleteButton
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("android:id/button1"), "Delete Button"); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEditContactPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The Appium test object</param>
        public AddEditContactPageModel(IAppiumTestObject testObject)
            : base(testObject)
        {
        }

        /// <summary>
        /// Enters fullname
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void EnterName(string firstName, string lastName)
        {
            // Hides the soft keyboard
            this.TestObject.AppiumDriver.HideKeyboard();

            FirstNameInput.Clear();
            FirstNameInput.SendKeys(firstName);
            LastNameInput.Clear();
            LastNameInput.SendKeys(lastName);
        }

        /// <summary>
        /// Enters phone
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void EnterPhone(string phoneNumber)
        {
            PhoneNumberInput.Clear();
            PhoneNumberInput.SendKeys(phoneNumber);
        }

        /// <summary>
        /// Selects phone category
        /// </summary>
        /// <param name="phoneCategory"></param>
        public void SelectPhoneCategory(string phoneCategory)
        {
            PhoneCategoryDropdown.Click();
            GenericWait.Wait(() => PhoneCategoryDropdownMenu.Displayed, TimeSpan.FromMilliseconds(500), TimeSpan.FromMilliseconds(500), false);
            PhoneCategoryDropdownOptions.First(i => i.Text.Equals(phoneCategory)).Click();
        }

        /// <summary>
        /// Enters email
        /// </summary>
        /// <param name="email"></param>
        public void EnterEmail(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
        }

        /// <summary>
        /// Taps save button
        /// </summary>
        /// <returns></returns>
        public ContactDetailsPageModel TapSaveButton()
        {
            SaveButton.Click();
            return new ContactDetailsPageModel(this.TestObject);
        }

        /// <summary>
        /// Taps more field link
        /// </summary>
        public void TapMoreFieldsLink()
        {
            // Simulate scrolling up
            TouchAction touch = new TouchAction(this.AppiumDriver);
            touch.Press(PhoneIcon, 0, 10)
                .MoveTo(PersonIcon, 0, 10)
                .Release()
                .Perform();

            MoreFieldLink.Click();
        }

        /// <summary>
        /// Enters company name
        /// </summary>
        /// <param name="companyName"></param>
        public void EnterCompanyName(string companyName)
        {
            CompanyNameInput.Clear();
            CompanyNameInput.SendKeys(companyName);
        }

        /// <summary>
        /// Delete contact
        /// </summary>
        public void DeleteContact()
        {
            MoreOptionsIcon.Click();
            GenericWait.Wait(() => DeleteOption.Displayed, TimeSpan.FromMilliseconds(500), TimeSpan.FromMilliseconds(500), false);
            DeleteOption.Click();
            DeleteButton.Click();
        }

        /// <summary>
        /// Check that the page is loaded
        /// </summary>
        /// <returns>True if the time is displayed</returns>
        public override bool IsPageLoaded()
        {
            return FirstNameInput.Exists;
        }
    }
}
