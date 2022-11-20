using CognizantSoftvision.Maqs.BaseAppiumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageModel;

namespace Tests
{
    /// <summary>
    /// AppiumTestsVSUnit test class with VSUnit
    /// </summary>
    [TestClass]
    public class ContactsTest : BaseAppiumTest
    {

        /// <summary>
        /// Verify adding of new contact
        /// </summary>
        [TestMethod]
        public void AddContactTest()
        {
            string firstName = "Cassian";
            string lastName = "Andor";
            string fullName = firstName + " " + lastName;
            string phone = "911";
            string phoneCategory = "Work";
            string email = "andor@testdata.com";
            string company = "The empire";

            // Instantiate starting page object model class
            ContactsPageModel contactPage = new ContactsPageModel(this.TestObject);

            // 2. Add new contact

            // With handling to cancel Add account popup
            AddEditContactPageModel addEditContactPage = contactPage.TapCreateNewContactIcon();

            // With device key command to hide mobile keyboard
            addEditContactPage.EnterName(firstName, lastName);
            addEditContactPage.EnterPhone(phone);

            // Using LINQ to select category
            addEditContactPage.SelectPhoneCategory(phoneCategory);
            addEditContactPage.EnterEmail(email);
            ContactDetailsPageModel contactDetailsPage = addEditContactPage.TapSaveButton();

            // 3. Verifies if the new contact is added in the list

            // With navigation command to go backwards
            contactDetailsPage.TapBackButton();
            contactPage.IsNewContactDisplayed(fullName);

            // 4-5. Edit newly added contact
            contactDetailsPage.TapEditContactIcon();

            // With touch action command to simulate scrolling
            addEditContactPage.TapMoreFieldsLink();
            addEditContactPage.EnterCompanyName(company);
            addEditContactPage.TapSaveButton();

            // 6. Verifies if the new contact is added in the list
            contactDetailsPage.IsCompanyReflectedAsOrganization(company);

            // 7. Set new contact as favorite
            contactDetailsPage.TapFavoriteIcon();
            contactDetailsPage.TapBackButton();

            // 8. Verifies if new contact is set as favorite
            SoftAssert.Assert(() => Assert.IsTrue(contactPage.IsNewContactSetAsFavorite(fullName), "Contact not set as favorite"));

            // Gathers failed assertions
            SoftAssert.FailTestIfAssertFailed();
        }

        /// <summary>
        /// Removes the new contact
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            string firstName = "Cassian Andor";

            // Instantiate starting page object model class
            ContactsPageModel contactPage = new ContactsPageModel(this.TestObject);

            // Search for the contact and delete it
            AddEditContactPageModel addEditContactPage = contactPage.TapContactName(firstName);
            addEditContactPage.DeleteContact();
        }
    }
}
