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
     class TopSellersPageObject
    {
        private IWebDriver driver;
        private readonly By _LinuxCheckBox = By.XPath("//span[@data-value='linux']//span[@class='tab_filter_control_checkbox']");
        private readonly By _PlayerNumberBtn = By.XPath("//div[@data-collapse-name='category3']");
        private readonly By _LanCoopCheckbox = By.XPath("//div[@data-value='48']");
        private readonly By _ActionCheckbox = By.XPath("//span[@data-value='19' and @data-param='tags']");
        private readonly By _GameName = By.XPath("//a[contains(@class,'search_result_row')][1]//span[@class='title']");
        private readonly By _GameData = By.XPath("//a[contains(@class,'search_result_row')][1]//div[contains(@class,'search_released')]");
        private readonly By _GamePrice = By.XPath("//a[contains(@class,'search_result_row')][1]//div[contains(@class,'search_price')]");
        private readonly By _GameBtn = By.XPath("//a[contains(@class,'search_result_row')][1]");

        private readonly By _NoteworthyPageUniqueElement = By.XPath("//div[@id='additional_search_options']");
        private readonly By _LinuxBtnChecked = By.XPath("//div[@data-value='linux' and contains(@class,'checked')]");
        private readonly By _LanBtnChecked = By.XPath("//div[@data-value='48' and contains(@class,'checked')]");
        private readonly By _ActionBtnChecked = By.XPath("//div[@data-value='19' and contains(@class,'checked')]");
        private readonly By _VerifyAppName = By.XPath("//div[@id='appHubAppName']");
        private readonly By _VerifyAppDate = By.XPath("//div[@class='date']");
        private readonly By _VerifyAppPrice = By.XPath("//div[contains(@class,'purchase_price')]");


        public TopSellersPageObject (IWebDriver driver)
        {
            this.driver = driver;
        }


        public By GetLanCoopCheckbox()
        {
            return _LanCoopCheckbox;
        }
        public By GetGameName()
        {
            return _GameName;
        }
        public By GetGameData()
        {
            return _GameData;
        }
        public By GetGamePrice()
        {
            return _GamePrice;
        }

        public By GetNoteworthyPageUniqueElement()
        {
            return _NoteworthyPageUniqueElement;
        }
        public By GetLinuxBtnChecked()
        {
            return _LinuxBtnChecked;
        }
        public By GetLanBtnChecked()
        {
            return _LanBtnChecked;
        }
        public By GetActionBtnChecked()
        {
            return _ActionBtnChecked;
        }
        public By GetVerifyAppName()
        {
            return _VerifyAppName;
        }
        public By GetVerifyAppDate()
        {
            return _VerifyAppDate;
        }
        public By GetVerifyAppPrice()
        {
            return _VerifyAppPrice;
        }







        public void LinuxCheckBoxClick()
        {
            var LinuxCheckBox = driver.FindElement(_LinuxCheckBox);
            LinuxCheckBox.Click();
        }

        public void PlayerNumberBtnClick()
        {
            var PlayerNumberBtn = driver.FindElement(_PlayerNumberBtn);
            PlayerNumberBtn.Click();
        }

        public void LanCoopCheckboxClick()
        {
            var LanCoopCheckbox = driver.FindElement(_LanCoopCheckbox);
            LanCoopCheckbox.Click();
        }

        public void ActionCheckBoxClick()
        {
            var ActionCheckBox = driver.FindElement(_ActionCheckbox);
            ActionCheckBox.Click();
        }

        public void GameBtnClick()
        {
            var GameBtn = driver.FindElement(_GameBtn);
            GameBtn.Click();
        }
    }
}
