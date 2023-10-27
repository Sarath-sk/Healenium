using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Pages
{
    internal class Login
    {
        IWebDriver driver;

        public Login(IWebDriver dr)
        {
            driver = dr;
            // To initialise page elements
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "user-name")]
        IWebElement userName;

        [FindsBy(How = How.Name, Using = "password")]
        IWebElement password;

        [FindsBy(How = How.Name, Using = "login-button")]
        IWebElement login;

        public void loginToStandardUser() {
            userName.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            login.Click();
        }


        //locked_out_user
        public void loginToLockedUser()    
        {
            userName.SendKeys("locked_out_user");
            password.SendKeys("secret_sauce");
            login.Click();
        }   

    }
}
    