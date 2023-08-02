using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.FedCm;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MarsQA_1.SpecflowPages.Pages
{

    public class Skills : CommonDriver
    {
        IWebElement SkillsTab => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        IWebElement AddSkillBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        IWebElement SkillName => Driver.driver.FindElement(By.Name("name"));
        IWebElement SkillLevelDropdown => Driver.driver.FindElement(By.Name("level"));
        IWebElement Skill => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        IWebElement editButton => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        //IWebElement editButton => Driver.driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        IWebElement updateButton => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        //IWebElement CancelBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
        IWebElement CancelBtn => Driver.driver.FindElement(By.XPath("//input[@value='Cancel']"));
        IWebElement Popup => Driver.driver.FindElement(By.ClassName("ns-box-inner"));
        IWebElement EditSkillName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        IWebElement RemoveButton => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));

        IWebElement SKill1 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        IWebElement Skill2 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
        IWebElement Skill3 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
        IWebElement Skill4 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td[1]"));
        IWebElement Skill5 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[5]/tr/td[1]"));

        public void CleanSkillsTable()
        {
            try
            {
                while (RemoveButton.Displayed)
                {
                    RemoveButton.Click();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Moving to Skilltab
        public void skillsTab()
        {
            SkillsTab.Click();
            Thread.Sleep(10000);
        }

        //Add Skill
        public void AddSkill(string skillName, string level)
        {
            CleanSkillsTable();
            string[] skillsName = { "SQL", "Oracle", "API", "Selenium", "DataAnalyst" };

            foreach (var skill in skillsName)
            {
                //AddLanguage(lang, "Fluent");

                AddSkillBtn.Click();
                SkillName.SendKeys(skill);
                var SelectElement = new SelectElement(SkillLevelDropdown);
                SkillLevelDropdown.Click();
                SelectElement.SelectByValue("Intermediate");
                AddButton.Click();

            }

        }

        //All Added skills validation
        public string AddedSkill(string skillName)
        {
            //return SkillName.ToString();
            switch (skillName)
            {
                case "SQL":
                    return SKill1.Text;

                case "Oracle":
                    return Skill2.Text;

                case "API":
                    return Skill3.Text;

                case "Selenium":
                    return Skill4.Text;

                case "DataAnalyst":
                    return Skill5.Text;

                default:
                    return string.Empty;

            }

        }

        //Edit Skills
        public void EditSkill()
        {
            SkillsTab.Click();
            editButton.Click();

            SkillName.Clear();
            SkillName.SendKeys("WebIO");
            //Thread.Sleep(2000);

            var SelectLevel = new SelectElement(SkillLevelDropdown);
            SelectLevel.SelectByValue("Expert");


            updateButton.Click();

            // Thread.Sleep(3000);
        }
        //Updating Skills
        public string UpdatedSkillValidation()
        {
            return SKill1.Text;
        }

        /* public string EditProfileSkill(IWebDriver driver)
         {

             return EditSkillName.Text;
         }*/

        //Adding existing Skills
        public void ExistingSkill(string skillName, string level)
        {
            SkillsTab.Click();
            editButton.Click();

            SkillName.Clear();
            SkillName.SendKeys("DataAnalyst");
            Thread.Sleep(2000);
        }

        //Validating existing skill
        public void ExistingSkillAdded()
        {
            updateButton.Click();

        }
        //Validating Existing Pop up message
        public bool ExistingPopupValidation()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Deleting Skills
        public void DeleteSkill()
        {
            SkillsTab.Click();
            RemoveButton.Click();
        }
        //Validating the Skillsdeletion
        public bool ValidateSkillIsDeleted()
        {
            try
            {
                RemoveButton.Click();
                return false;
            }
            catch
            {
                return true;
            }
        }

        //ReAdd and canceling skill
        public void ReAddSkill()
        {
            SkillsTab.Click();
            AddSkillBtn.Click();
            SkillName.SendKeys("API Test");
            var SelectLevel = new SelectElement(SkillLevelDropdown);
            SelectLevel.SelectByValue("Intermediate");


        }

        //Added skill cancellation
        public void CancelAddSkill()
        {
            CancelBtn.Click();
        }

        //Validating cancelled skill
        public bool EnsureSkillNotAdded()
        {
            if (Driver.driver.PageSource.Contains("API Test"))
            {
                return false;
            }

            else
            {
                return true;
            }

        }
        //Validation of Cancel skill Pop up
        public string PopupValidation()
        {
            try
            {
                return Popup.Text;
            }
            catch (Exception ex)
            {
                return "Popup element not found";
            }
        }
        //Validating Invalid skillName
        public void InvalidSkillName(string skillName, string level)
        {
            SkillsTab.Click();
            AddSkillBtn.Click();
            SkillName.SendKeys("1234");
            SkillLevelDropdown.Click();

            var SelectLevel = new SelectElement(SkillLevelDropdown);
            SelectLevel.SelectByValue("Intermediate");


        }

        //Validating Invalid skill
        public bool ValidateInvalidSkill()
        {
            try
            {
                AddButton.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Add Blank Skilllevel
        public void InvalidSkillLevel(string level)
        {
            SkillsTab.Click();
            AddSkillBtn.Click();
            SkillName.SendKeys("RPA");
            SkillLevelDropdown.Click();

            var SelectLevel = new SelectElement(SkillLevelDropdown);
            SelectLevel.SelectByValue("");


        }
        //Validate Blank SkillLevel
        public bool ValidateInvalidSkillLevel()
        {
            try
            {
                AddButton.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }

}

   
