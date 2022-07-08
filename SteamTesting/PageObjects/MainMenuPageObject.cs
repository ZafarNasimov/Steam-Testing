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
     class MainMenuPageObject
    {
        private  IWebDriver driver;
        private readonly By _AboutButton = By.XPath("//div[@class='supernav_container']//a[contains(@href,'about')]");
        private readonly By _OpenStore = By.XPath("//div[@class='supernav_container']//a[@data-tooltip-content='.submenu_store']");
        private readonly By _MainMenu = By.XPath("//span[@id='logo_holder']");
        private readonly By _NoteWorthyBtn = By.XPath("//div[@id='noteworthy_tab']");
        private readonly By _TopSellersBtn = By.XPath("//a[@class='popup_menu_item' and contains(@href,'topsellers')]");
        private readonly By _SteamMainPageUniqueElement = By.XPath("//div[@id='home_maincap_v7']");

        private readonly By _CommunityBtn = By.XPath("//div[@id='global_header']//a[@data-tooltip-content='.submenu_community']");
        private readonly By _MarketBtn = By.XPath("//div[@class='responsive_page_content']//a[contains(@href,'market')]");

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }


        public By GetCommunityBtn()
        {
            return _CommunityBtn;
        }
        public By GetSteamMainPageUniqueElement()
        {
            return _SteamMainPageUniqueElement;
        }

        public By GetMarketBtn()
        {
            return _MarketBtn;
        }

        public void AboutButtonClick()
        {
            var Aboutbtn = driver.FindElement(_AboutButton);
            Aboutbtn.Click();
        }

        public void OpenStoreClick()
        {
            var OpenStorebtn = driver.FindElement(_OpenStore);
            OpenStorebtn.Click();
        }

        public void MainMenuClick()
        {
            var MainMenubtn = driver.FindElement(_MainMenu);
            MainMenubtn.Click();
        }

        public void NoteworthyBtnClick()
        {
            var NoteWorthyBtn = driver.FindElement(_NoteWorthyBtn);
            NoteWorthyBtn.Click();
        }

        public void TopSellersClick()
        {
            var TopSellersBtn = driver.FindElement(_TopSellersBtn);
            TopSellersBtn.Click();
        }







    }
}
