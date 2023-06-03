using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Skills
    {
        public void skillsTab(IWebDriver driver)
        {
            IWebElement SkillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillsTab.Click();
            Thread.Sleep(10000);
        }
        public void AddSkill(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement AddSkillBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddSkillBtn.Click();

            IWebElement SkillName = driver.FindElement(By.Name("name"));
            SkillName.SendKeys("SQL");

            IWebElement SkillLevelDropdown = driver.FindElement(By.Name("level"));
            //SkillLevelDropdown.Click();

            var SelectLevel = new SelectElement(SkillLevelDropdown);
            SelectLevel.SelectByValue("Intermediate");

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton.Click();

            Thread.Sleep(5000);
        }

        public string AddedSkill(IWebDriver driver)
        {
            IWebElement Skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return Skill.Text;
        }


        public void EditSkill(IWebDriver driver)
        {
           

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editButton.Click();

            IWebElement SkillName = driver.FindElement(By.Name("name"));
            SkillName.Clear();
            SkillName.SendKeys("Selenium");
            Thread.Sleep(2000);
            IWebElement SkillLevelDropdown = driver.FindElement(By.Name("level"));

            var SelectLevel = new SelectElement(SkillLevelDropdown);
            SelectLevel.SelectByValue("Expert");

            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();

            Thread.Sleep(3000);
        }

        public string EditProfileSkill(IWebDriver driver)
        {
            IWebElement EditSkillName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return EditSkillName.Text;
        }
        public void DeleteSkill(IWebDriver driver)
        {
            IWebElement RemoveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            RemoveButton.Click();
        }
    }
}
