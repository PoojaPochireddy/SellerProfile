using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SellerFeatureStepDefinitions : CommonDriver
    {
        Skills SkillsObj = new Skills();
        [Given(@"User is logged into SellerProfile application")]
        public void GivenUserIsLoggedIntoSellerProfileApplication()
        {
            driver = new ChromeDriver();

            LoginSteps loginObj = new LoginSteps();
            loginObj.Login(driver);
            
        }

        [When(@"User adds new Skill")]
        public void WhenUserAddsNewSkill()
        {
            SkillsObj.skillsTab(driver);
            SkillsObj.AddSkill(driver);
        }

        [Then(@"Newly added Skill is displayed in the Skills list on user profile")]
        public void ThenNewlyAddedSkillIsDisplayedInTheSkillsListOnUserProfile()
        {
            string addedSkill = SkillsObj.AddedSkill(driver);
            Assert.That(addedSkill == "SQL", "SQL is added as a Skill");
            //driver.Quit();
            //driver.Dispose();
        }

        [When(@"User edits newly added Skill")]
        public void WhenUserEditsNewlyAddedSkill()
        {
            SkillsObj.skillsTab(driver);
            SkillsObj.EditSkill(driver);
        }

        [Then(@"Skill is edited successfully")]
        public void ThenSkillIsEditedSuccessfully()
        {
            SkillsObj.skillsTab(driver);
            string editedSkill = SkillsObj.EditProfileSkill(driver);
            Assert.That(editedSkill == "Selenium", "Edited the Skill");
            //driver.Quit();
            //driver.Dispose();
        }

        [When(@"User deletes newly added Skill")]
        public void WhenUserDeletesNewlyAddedSkill()
        {
            SkillsObj.skillsTab(driver);
            SkillsObj.DeleteSkill(driver);
        }
    }
}
