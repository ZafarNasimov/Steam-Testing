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
     class MarketPageObject
    {
        private IWebDriver driver;

        private readonly By _AdvancedSearch = By.XPath("//div[@class='market_search_advanced_button']");
        private readonly By _AllGamesBtn = By.XPath("//div[@id='app_option_0_selected']");
        private readonly By _DotaBtn = By.XPath("//div[@id='app_option_570']");
        private readonly By _DotaHeroBtn = By.XPath("//select[@name='category_570_Hero[]']");
        private readonly By _LifeStealerOption = By.XPath("//option[contains(@value,'life_stealer')]");
        private readonly By _RarityImmortalOption = By.XPath("//input[@id='tag_570_Rarity_Rarity_Immortal']");
        private readonly By _SearchBox = By.XPath("//input[@id='advancedSearchBox']");
        private readonly By _SearchBtn = By.XPath("//div[@class='market_advancedsearch_bottombuttons']//div[contains(@onclick,'submit()')]");
        private readonly By _RemoveGoldenCategory = By.XPath("//a[@class='market_searchedForTerm'][4]");
        private readonly By _RemoveDota2Category = By.XPath("//a[@class='market_searchedForTerm'][1]");

        private readonly By _MarketPageUniqueElement = By.XPath("//div[@class='market_header_logo']");
        private readonly By _VerifyDotaCategory = By.XPath("//a[@class='market_searchedForTerm'][1]");
        private readonly By _VerifyLifestealerCategory = By.XPath("//a[@class='market_searchedForTerm'][2]");
        private readonly By _VerifyImmortalCategory = By.XPath("//a[@class='market_searchedForTerm'][3]");
        private readonly By _VerifyGoldenCategory = By.XPath("//a[@class='market_searchedForTerm'][4]");
        private readonly By _VerifyGame1 = By.XPath("//span[@id='result_0_name']");
        private readonly By _VerifyGame2 = By.XPath("//span[@id='result_1_name']");
        private readonly By _VerifyGame3 = By.XPath("//span[@id='result_2_name']");
        private readonly By _VerifyGame4 = By.XPath("//span[@id='result_3_name']");
        private readonly By _VerifyGame5 = By.XPath("//span[@id='result_4_name']");
        private readonly By _FinalResultGameBtn = By.XPath("//div[@id='result_0']");
        private readonly By _VerifyItem1 = By.XPath("//span[@id='result_0_name']");
        private readonly By _VerifyFinalItemName = By.XPath("//h1[@id='largeiteminfo_item_name']");
        private readonly By _VerifyFinalGameName = By.XPath("//div[@id='largeiteminfo_game_name']");
        private readonly By _VerifyFinalItemType = By.XPath("//div[@id='largeiteminfo_item_type']");
        private readonly By _VerifyFinalHeroType = By.XPath("//div[@id='largeiteminfo_item_descriptors']");

        public MarketPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool GoldenCategory()
        {
            try
            {
                driver.FindElement(_VerifyGoldenCategory);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public By GetMarketPageUniqueElement()
        {
            return _MarketPageUniqueElement;
        }

        public By GetAdvancedSearch()
        {
            return _AdvancedSearch;
        }

        public By GetAllGamesBtn()
        {
            return _AllGamesBtn;
        }

        public By GetDotaBtn()
        {
            return _DotaBtn;
        }

        public By GetDotaHeroBtn()
        {
            return _DotaHeroBtn;
        }

        public By GetLifeStealerOption()
        {
            return _LifeStealerOption;
        }

        public By GetRarityImmortalOption()
        {
            return _RarityImmortalOption;
        }


        public By GetSearchBox()
        {
            return _SearchBox;
        }

        public By GetSearchBtn()
        {
            return _SearchBtn;
        }

        public By Get_VerifyDotaCategory()
        {
            return _VerifyDotaCategory;
        }

        public By Get_VerifyLifestealerCategory()
        {
            return _VerifyLifestealerCategory;
        }

        public By Get_VerifyImmortalCategory()
        {
            return _VerifyImmortalCategory;
        }

        public By Get_VerifyGoldenCategory()
        {
            return _VerifyGoldenCategory;
        }

        public By Get_VerifyGame1()
        {
            return _VerifyGame1;
        }

        public By Get_VerifyGame2()
        {
            return _VerifyGame2;
        }

        public By Get_VerifyGame3()
        {
            return _VerifyGame3;
        }

        public By Get_VerifyGame4()
        {
            return _VerifyGame4;
        }

        public By Get_VerifyGame5()
        {
            return _VerifyGame5;
        }

        public By GetRemoveGoldenCategory()
        {
            return _RemoveGoldenCategory;
        }

        public By GetRemoveDota2Category()
        {
            return _RemoveDota2Category;
        }

        public By GetVerifyItem1()
        {
            return _VerifyItem1;
        }

        public By GetFinalResultGameBtn()
        {
            return _FinalResultGameBtn;
        }

        public By GetVerifyFinalItemName()
        {
            return _VerifyFinalItemName;
        }

        public By GetVerifyFinalGameName()
        {
            return _VerifyFinalGameName;
        }

        public By GetVerifyFinalItemType()
        {
            return _VerifyFinalItemType;
        }

        public By GetVerifyFinalHeroType()
        {
            return _VerifyFinalHeroType;
        }
    }
}
