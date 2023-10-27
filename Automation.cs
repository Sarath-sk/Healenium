using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using SeleniumProject.Pages;

namespace SeleniumProject
{
    public class Automation
    {
        //RemoteWebDriver driver;
        //IWebDriver driver;
        Login login;

        [SetUp]
        public void setup()
        {
            String nodeURL = "http://localhost:8085";

            EdgeOptions optionsChrome = new EdgeOptions();
            optionsChrome.AddArguments("--no-sandbox");
            optionsChrome.AddArguments("--selenium-manager true");

            RemoteWebDriver driverChrome = new RemoteWebDriver(new Uri(nodeURL), optionsChrome);
            //driver = new RemoteWebDriver(new Uri(""),;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driverChrome.Navigate().GoToUrl("https://www.saucedemo.com/");

            login = new Login(driverChrome);
        }


        [Test(Author ="Ramya", Description ="This testcase launches the google..")]
        public void Login()
        {
            login.loginToStandardUser();
        }

    }
}