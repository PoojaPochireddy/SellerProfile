using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MarsQA_1.SpecflowPages.Helpers;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class LoginSteps
    {
        public void Login(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            //Enter Url
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("pujapochireddy@gmail.com");

            //Enter password
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("Chaitu$123");

            //Click on Login Button
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

            Thread.Sleep(3000);


        }
    }
}
