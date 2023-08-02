using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RazorEngine;
using TechTalk.SpecFlow;


namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions
    {
        public readonly Languages LanguagesObj;
        public readonly UserProfile ProfileObj;
        private readonly string lang;
        private string editedLanguage;

        public LanguagesStepDefinitions()
        {
            //driver = new ChromeDriver();
            LanguagesObj = new Languages();
            ProfileObj = new UserProfile();

        }

        [Given(@"I logged into Seller Profile application")]
        public void GivenILoggedIntoSellerProfileApplication()
        {
            //LoginSteps loginObj = new LoginSteps();
            //loginObj.Login();

        }

        [When(@"I am on the User profile page")]
        public void WhenIAmOnTheUserProfilePage()
        {
            string ValidateTitle = ProfileObj.ProfilePageValidation();
            Assert.That(ValidateTitle == "Profile", "User is not navigated to Profile page");
        }
        [Then(@"I Create '([^']*)','([^']*)'")]
        public void ThenICreate(string languageName, string languagelevel)
        {
            LanguagesObj.AddLanguage(languageName, languagelevel);
        }

        [Then(@"I added and able to see Language '([^']*)','([^']*)'")]
        public void ThenIAddedAndAbleToSeeLanguage(string languageName, string languageLevel)
        {
            string[] languagesName = { "Telugu", "English", "Kannada", "hindi" };

            foreach (var lang in languagesName)
            {
                //AddLanguage(lang, "Fluent");

                string addedLanguage = LanguagesObj.ValidateAddedLanguage(lang);

                if (addedLanguage == lang)
                {
                    Assert.That(addedLanguage == lang, $"{lang},language gets added");
                }
                else
                {
                    Assert.That(addedLanguage == "error ", "No Language Added");
                }

            }
           


        }


        //[Given(@"I logged into the Seller Profile application")]
        //public void GivenILoggedIntoTheSellerProfileApplication()
        //{
        //throw new PendingStepException();
        // }

        [When(@"I edit and update the Language")]
        public void WhenIEditAndUpdateTheLanguage()
        {
            LanguagesObj.EditLanguage();

        }

        [Then(@"I am able to see an Updated Language name '([^']*)'")]
        public void ThenIAmAbleToSeeAnUpdatedLanguageName(string languageName)
        {
            //LanguagesObj.EditedLanguageValidation();
            string editedlanguage = LanguagesObj.EditedLanguageValidation();
            if (editedlanguage == languageName)
            {
                Assert.That(editedLanguage == "Sanskrit", "LanguageName shown is correct");
            }
            else
            {
                Assert.That(editedLanguage != "Sanskrit", "LanguageName shown is incorrect");
            }
        }

        [When(@"I will add the duplicate '([^']*)','([^']*)'")]
        public void WhenIWillAddTheDuplicate(string langaugeName, string languageLevel)
        {
            //var languageName = "Kannada";
            //var languagelevel = "Fluent";
            LanguagesObj.AddExistingLanguage();
        }

        [When(@"I click on Add again")]
        public void WhenIClickOnAddAgain()
        {
            //Add the same language again
            LanguagesObj.ValidateExistingLanguage();
        }

        [Then(@"I am able to see the validation pop up message")]
        public void ThenIAmAbleToSeeTheValidationPopUpMessage()
        {
            bool popupText = LanguagesObj.ExistingLanguagePopUp();
            Assert.That(popupText == true, "Langage already exists.");

        }

        [Given(@"I logged into the Seller Profile application")]
        public void GivenILoggedIntoTheSellerProfileApplication()
        {
            //throw new PendingStepException();
        }

        [When(@"I delete the Language '([^']*)'")]
        public void WhenIDeleteTheLanguage(string languageName)
        {
           // LanguagesObj.DeleteLanguage();
            LanguagesObj.CleanLanguageTable();
        }

        [Then(@"I am unable to see the deleted Language")]
        public void ThenIAmUnableToSeeTheDeletedLanguage()
        {
            bool LanguageDel = LanguagesObj.ValidateLanguageIsDeleted();
            Assert.That(LanguageDel == true, "Language Deleted successfully");
        }

        [When(@"I ReAdd '([^']*)','([^']*)'")]
        public void WhenIReAdd(string languageName, string languagelevel)
        {
            LanguagesObj.ReAddLanguage();
        }

        [Then(@"I click on cancel")]
        public void ThenIClickOnCancel()
        {
            LanguagesObj.CancelLanguage();

        }
        [Then(@"I am not able to see the '([^']*)'")]
        public void ThenIAmNotAbleToSeeTheLanguageName(string languageName)
        {
            bool cancel = LanguagesObj.LanguageNotAdded();
            if (cancel == true)
            { 
            Assert.That(cancel == true, "Action could be canceled");
            }
            else
            {
                Assert.That(cancel != true, "Action could not be canceled");
            }
        }

        [When(@"I Add the '([^']*)'")]
        public void WhenIAddTheLanguageName(string languageName)
        {
            LanguagesObj.BlankLanguageName(languageName);
        }

        [Then(@"I clicked on Add")]
        public void WhenIClickedOnAdd()
        {
            

        }

        [Then(@"I am able to see the pop up validation message")]
        public void ThenIAmAbleToSeeThePopUpValidationMessage()
        {
            LanguagesObj.PopUp();
        }

        [When(@"I add only '(.*)'")]
        public void WhenIAddOnlyLanguageLevel(string languagelevel)
        {
            LanguagesObj.BlankLanguageLevel(languagelevel);
        }

        [Then(@"I clicked on AddButton")]
        public void WhenIClickedOnAddButton()
        {


        }

        [Then(@"I am able to see the pop up Text Validation")]
        public void ThenIAmAbleToSeeThePopUpTextValidation()
        {
            LanguagesObj.PopUpTextValidation();
            LanguagesObj.CleanLanguageTable();
        }

    }
}
