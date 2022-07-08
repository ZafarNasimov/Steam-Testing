using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;
using SteamTesting.PageObjects;

namespace SteamTesting.PageObjects
{



         class AboutPageObject
    {
        private IWebDriver driver;
        private readonly By _OnlineGamers = By.XPath("//div[@class='online_stat']");
        private readonly By _Gamers_in_Game = By.XPath("//div[@class='online_stat'][2]");
        private readonly By _AboutPageUniqueElement = By.XPath("//div[@class='online_stats']");


        public AboutPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By GetAboutPageUniqueElement()
        {
            return _AboutPageUniqueElement;
        }

        public By OnlineGamersLink()
        {
            return _OnlineGamers;
        }

        public By GameGamersLink()
        {
            return _Gamers_in_Game;
        }


        public int ElementToText(By var)
        {
            IWebElement element = driver.FindElement(var);
            string text = element.Text;
            int num;
            int.TryParse(string.Join("", text.Where(c => char.IsDigit(c))), out num);
            return num;
        }
    }
}
