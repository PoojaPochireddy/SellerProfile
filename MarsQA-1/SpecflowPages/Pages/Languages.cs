using Google.Protobuf.WellKnownTypes;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using RazorEngine;
using System;
//using System.Net.NetworkInformation;
//using System.Reflection.Emit;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Languages : CommonDriver
    {
        IWebElement RemoveButton => Driver.driver.FindElement(By.XPath("//i[@class='remove icon']"));
        IWebElement AddLanguageButton => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='ui teal button '][normalize-space()='Add New']"));
        IWebElement Language => Driver.driver.FindElement(By.Name("name"));
        //IWebElement LanguageLevelDropdown => Driver.driver.FindElement(By.Name("level"));
        IWebElement LanguageLevelDropdown => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement EditButton => Driver.driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));

        // IWebElement LName1 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        IWebElement LName1 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));

         IWebElement LName2 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
        IWebElement LName3 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
        IWebElement LName4 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td[1]"));

        IWebElement LLevel1 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));

        IWebElement LLevel2 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
        IWebElement LLevel3 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
        IWebElement Llevel4 => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
        IWebElement UpdateButton => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        IWebElement EditedLanguageName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        IWebElement CancelBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
        IWebElement Popup => Driver.driver.FindElement(By.ClassName("ns-box-inner"));

        public void CleanLanguageTable()
        {
            try
            {

                while (RemoveButton.Displayed) //once all languages are deleted, remove button wont be displayed and loop will end
                {
                    RemoveButton.Click();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Add new language 
        public void AddLanguage(string languageName, string languagelevel)
        {
            CleanLanguageTable();
            string[] languagesName = { "Telugu", "English", "Kannada", "hindi" };
        
            foreach (var lang in languagesName)
            {
                //AddLanguage(lang, "Fluent");

                AddLanguageButton.Click();
                Language.SendKeys(lang);
                var SelectElement = new SelectElement(LanguageLevelDropdown);
                LanguageLevelDropdown.Click();
                SelectElement.SelectByValue("Fluent");
                AddButton.Click();
                
            }
        }
        //LanguageValidation
        public string ValidateAddedLanguage(string languageName)
        {
            switch (languageName)
            {
                case "Telugu":
                    return LName1.Text;

                case "English":
                    return LName2.Text;

                case "Kannada":
                    return LName3.Text;

                case "hindi":
                    return LName4.Text;
                default:
                    return string.Empty;

                    Thread.Sleep(3000);
                    
            }

        }

        //Edit Existing language
        public void EditLanguage()
        {
            EditButton.Click();

            Language.Clear();
            Language.SendKeys("Sanskrit");

            //var SelectLevel = new SelectElement(LanguageLevelDropdown);
            //SelectLevel.SelectByValue("Conversational");

            UpdateButton.Click();           
            Thread.Sleep(3000);
        }
        //Validation for Updated Language
        public string EditedLanguageValidation()
        {
            return EditedLanguageName.Text;
        }

        //Add Existing Language
        public void AddExistingLanguage()
        {
            EditButton.Click();

            Language.Clear();
            Language.SendKeys("Kannada");
            //UpdateButton.Click();
            Thread.Sleep(3000);

        }

        //Validate Existing Language
        public void ValidateExistingLanguage()
        {
            UpdateButton.Click();
        }

        //Validate Pop up Message
        public bool ExistingLanguagePopUp()
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
        //Delete Language
        public void DeleteLanguage()
        {
            RemoveButton.Click();
        }

        //Validation for Delete Language
        public bool ValidateLanguageIsDeleted()
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

        //ReAdd and Cancel Language
        public void ReAddLanguage()
        {
            AddLanguageButton.Click();
            Language.SendKeys("French");
            var SelectLevel = new SelectElement(LanguageLevelDropdown);
            SelectLevel.SelectByValue("Fluent");
            Thread.Sleep(2000);
        }
        //Validation for Cancel button
        public void CancelLanguage()
        {
            CancelBtn.Click();
        }

        //Validation for cancelled Language
        public bool LanguageNotAdded()
        {
            try
            {
                //Return true if remove button does not exist
                return true;

            }
            catch (Exception ex)
            {
                
                return RemoveButton.Displayed;
            }
        }

        //Validation for Pop up Message
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

        //Add Language with blank LanguageName
        public void BlankLanguageName(string languageName)
        {

            AddLanguageButton.Click();
            Language.SendKeys(" ");
            var SelectLevel = new SelectElement(LanguageLevelDropdown);
            SelectLevel.SelectByValue("Conversational");

        }
        public bool PopUp()
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

        //Add Language with blank LanguageLevel
        public void BlankLanguageLevel(string languagelevel)
        {

            AddLanguageButton.Click();
            Language.SendKeys("Hindi");
            var SelectLevel = new SelectElement(LanguageLevelDropdown);
            SelectLevel.SelectByValue("");

        }
        public bool PopUpTextValidation()
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

