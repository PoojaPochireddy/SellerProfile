using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Reflection.Emit;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions 
    {
        private readonly Skills SkillsObj;
        private readonly string skill;

        public SkillsFeatureStepDefinitions()
        {
            //driver = new ChromeDriver();

            SkillsObj = new Skills();   
        }
        [Given(@"I logged into SellerProfile application")]
        public void GivenILoggedIntoSellerProfileApplication()
        {
            //LoginSteps loginObj = new LoginSteps();
            //loginObj.Login();
        }

        [When(@"I click on SkillsTab")]
        public void WhenIClickOnSkillsTab()
        {
            SkillsObj.skillsTab();
        }

        [When(@"I Create the '([^']*)','([^']*)'")]
        public void WhenICreateThe(string skillName, string level)
        {
            SkillsObj.AddSkill(skillName, level);
        }

        [Then(@"I added Skills\.")]
        public void ThenIAddedSkills_()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I am able to see '([^']*)','([^']*)'")]

        public void ThenIAmAbleToSee(string skillName, string level)
        {
            //bool ShowskillName = true;
            //Assert.That(ShowskillName == true, "Newly Added skill shown as SQL in Table");
            string[] skillsName = { "SQL", "Oracle", "API", "Selenium", "DataAnalyst" };

            foreach (var skill in skillsName)
            {
                string SkillAdded = SkillsObj.AddedSkill(skillName);
                if (SkillAdded == skillName)
                {
                    Assert.That(SkillAdded == "SQL", "New Skill is added");
                }
                else
                {
                    Assert.That(SkillAdded != "error ", "No Skill Added");

                }
            }

        }
        [Given(@"I logged into the SellerProfile applictaion")]
        public void GivenILoggedIntoTheSellerProfileApplictaion()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I edit the Skills")]
        public void WhenIEditTheSkills()
        {
            SkillsObj.EditSkill();
        }

        [When(@"I update the '([^']*)'")]
        public void WhenIUpdateThe(string skillName)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I am able to see the Updated Skill name '(.*)'")]
        public void ThenIAmAbleToSeeTheUpdatedSkillName(string skillName)
        {
            
            String SkillEdited = SkillsObj.UpdatedSkillValidation();
            if (SkillEdited == skillName)
            {
                Assert.That(SkillEdited == "WebIO", "Skill edited successfully");
            }
            else
            {
                Assert.That(SkillEdited != "WebIO", "Skill doesnt edited as expected");
            }
        }

        [Given(@"I log into the SellerProfile application")]
        public void GivenILogIntoTheSellerProfileApplication()
        {

        }
        [When(@"I Recreate the duplicate '([^']*)','([^']*)'")]
        public void WhenIRecreateTheDuplicate(string skillName, string level)
        {
            SkillsObj.ExistingSkill(skillName, level);


        }
        [Then(@"I click on Add again")]
        public void ThenIClickOnAddAgain()
        {
            SkillsObj.ExistingSkillAdded();
        }

        [Then(@"I am able to see validation message")]
        public void ThenIAmAbleToSeeValidationMessage()
        {
            bool popupText =SkillsObj.ExistingPopupValidation();
            Assert.That(popupText == true, "Skill already exists.");
        }

        [Given(@"I logged into a SellerProfile application")]
        public void GivenILoggedIntoASellerProfileApplication()
        {

        }

        [When(@"I delete the skills '([^']*)'")]
        public void WhenIDeleteTheSkills(string skillName)
        {
            //SkillsObj.DeleteSkill();
            SkillsObj.CleanSkillsTable();
        }

        [Then(@"I am unable to see the deleted skill")]
        public void ThenIAmUnableToSeeTheDeletedSkill()
        {
            bool SkillDeleted = SkillsObj.ValidateSkillIsDeleted();
            Assert.That(SkillDeleted == true, "Skill Deleted Successfully");
        }

        [Given(@"I logged into the SellerProfile application")]
        public void GivenILoggedIntoTheASellerProfileApplication()
        {

        }

        [When(@"I ReAdd the '([^']*)','([^']*)'")]
        public void WhenIReAddThe(string skillName, string level)
        {
            SkillsObj.ReAddSkill();
        }

        [When(@"I click on Cancel")]
        public void WhenIClickOnCancel()
        {
            SkillsObj.CancelAddSkill();
        }

        [Then(@"I am able to see the <SkillName> is not added")]
        public void ThenIAmAbleToSeeTheSkillNameIsNotAdded()
        {
            bool cancel = SkillsObj.EnsureSkillNotAdded();
            Assert.That(cancel = true, "Skill doesnt gets added");
        }

        [Given(@"I logged in as a SellerProfile application")]
        public void GivenILoggedInAsASellerProfileApplication()
        {

        }

        [When(@"I Add the invalid '(.*)','(.*)'")]
        public void WhenIAddTheInvalid(string skillName, string level)
        {       
            SkillsObj.InvalidSkillName(skillName,level);

        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            bool InvalidName = SkillsObj.ValidateInvalidSkill();
            Assert.That(InvalidName == true, "1234 has been added to skill list");
        }

        [Then(@"I am able to see the validation message")]
        public void ThenIAmAbleToSeeTheValidationMessage()
        {
            //Console.WriteLine("Please add skill and level");
         }
        [Given(@"I logged in to SellerProfile application")]
        public void GivenILoggedInToASellerProfileApplication()
        {

        }

        [When(@"I donot Add the '(.*)'")]
        public void WhenIDonotAddThe(string level)
        {
            //ScenarioContext.Current.Pending();
            SkillsObj.InvalidSkillLevel(level);
        }

        [Then(@"I click on Add")]
        public void ThenIClickOnAdd()
        {
             SkillsObj.ValidateInvalidSkill();
            
        }

        [Then(@"I am able to see the Popup message")]
        public void ThenIAmAbleToSeeThePopupMessage()
        {
            SkillsObj.ValidateInvalidSkillLevel();
            SkillsObj.CleanSkillsTable();
        }


    }
}
