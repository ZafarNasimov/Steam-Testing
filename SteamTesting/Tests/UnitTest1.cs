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

namespace SteamTesting
{
    public class Tests 
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");

            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://store.steampowered.com/");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            MainMenuPageObject mainMenuPageObject = new MainMenuPageObject(driver);
            AboutPageObject aboutPageObject = new AboutPageObject(driver);
            TopSellersPageObject topSellersPageObject = new TopSellersPageObject(driver);
            MarketPageObject marketPageObject = new MarketPageObject(driver);

            Assert.IsTrue(driver.FindElement(mainMenuPageObject.GetSteamMainPageUniqueElement()).Displayed);

            
            
            mainMenuPageObject.AboutButtonClick();
            Assert.IsTrue(driver.FindElement(aboutPageObject.GetAboutPageUniqueElement()).Displayed);

            IWebElement element = driver.FindElement(aboutPageObject.OnlineGamersLink());
            string OnlineGamers = element.Text;
            int OnlineGamersnum;
            int.TryParse(string.Join("", OnlineGamers.Where(c => char.IsDigit(c))), out OnlineGamersnum);

            element = driver.FindElement(aboutPageObject.GameGamersLink());
            string GamersInGame = element.Text;
            int GameGamersnum;
            int.TryParse(string.Join("", GamersInGame.Where(c => char.IsDigit(c))), out GameGamersnum);
            Assert.IsTrue(OnlineGamersnum > GameGamersnum);

            mainMenuPageObject.OpenStoreClick();
            Assert.IsTrue(driver.FindElement(mainMenuPageObject.GetSteamMainPageUniqueElement()).Displayed);
        }

        [Test]
        public void Test2()
        {
            MainMenuPageObject mainMenuPageObject = new MainMenuPageObject(driver);
            AboutPageObject aboutPageObject = new AboutPageObject(driver);
            TopSellersPageObject topSellersPageObject = new TopSellersPageObject(driver);
            MarketPageObject marketPageObject = new MarketPageObject(driver);

            mainMenuPageObject.MainMenuClick();
            Assert.IsTrue(driver.FindElement(mainMenuPageObject.GetSteamMainPageUniqueElement()).Displayed);

            mainMenuPageObject.NoteworthyBtnClick();
            mainMenuPageObject.TopSellersClick();
            Assert.IsTrue(driver.FindElement(topSellersPageObject.GetNoteworthyPageUniqueElement()).Displayed);

            topSellersPageObject.LinuxCheckBoxClick();
            Assert.IsTrue(driver.FindElement(topSellersPageObject.GetLinuxBtnChecked()).Enabled);

            topSellersPageObject.PlayerNumberBtnClick();
            Assert.IsTrue(driver.FindElement(topSellersPageObject.GetLanCoopCheckbox()).Enabled);

            Thread.Sleep(100);
            topSellersPageObject.LanCoopCheckboxClick();
            Assert.IsTrue(driver.FindElement(topSellersPageObject.GetLanBtnChecked()).Enabled);

            topSellersPageObject.ActionCheckBoxClick();
            Assert.IsTrue(driver.FindElement(topSellersPageObject.GetActionBtnChecked()).Enabled);
            Thread.Sleep(1000);

            IWebElement element = driver.FindElement(topSellersPageObject.GetGameName());
            string GameName = element.Text;

            element = driver.FindElement(topSellersPageObject.GetGameData());
            string GameData = element.Text;

            element = driver.FindElement(topSellersPageObject.GetGamePrice());
            string GamePrice = element.Text;
            int NumGamePrice;
            int.TryParse(string.Join("", GamePrice.Where(c => char.IsDigit(c))), out NumGamePrice);
            Console.WriteLine(NumGamePrice);



            topSellersPageObject.GameBtnClick();

            var VerifyAppDate = driver.FindElement(topSellersPageObject.GetVerifyAppDate());
            var VerifyAppPrice = driver.FindElement(topSellersPageObject.GetVerifyAppPrice());
            int NumVerifyGamePrice;
            int.TryParse(string.Join("", VerifyAppPrice.Text.Where(c => char.IsDigit(c))), out NumVerifyGamePrice);
            Console.WriteLine(NumVerifyGamePrice);
            var VerifyAppName = driver.FindElement(topSellersPageObject.GetVerifyAppName());
            Assert.IsTrue(GameName == VerifyAppName.Text);
            //Assert.IsTrue(GameData == VerifyAppDate.Text);  BUG
            Assert.IsTrue(NumGamePrice == NumVerifyGamePrice);
        }

        [Test]
        public void Test3()
        {
            MainMenuPageObject mainMenuPageObject = new MainMenuPageObject(driver);
            AboutPageObject aboutPageObject = new AboutPageObject(driver);
            TopSellersPageObject topSellersPageObject = new TopSellersPageObject(driver);
            MarketPageObject marketPageObject = new MarketPageObject(driver);


            mainMenuPageObject.MainMenuClick();
            Assert.IsTrue(driver.FindElement(mainMenuPageObject.GetSteamMainPageUniqueElement()).Displayed);

            var CommunityBtn = driver.FindElement(mainMenuPageObject.GetCommunityBtn());
            var MarketBtn = driver.FindElement(mainMenuPageObject.GetMarketBtn());
            Actions builder = new Actions(driver);
            builder.MoveToElement(CommunityBtn).Click(MarketBtn);
            builder.Perform();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(marketPageObject.GetMarketPageUniqueElement()));
            Assert.IsTrue(driver.FindElement(marketPageObject.GetMarketPageUniqueElement()).Displayed);

            var AdvancedSearchBtn = driver.FindElement(marketPageObject.GetAdvancedSearch());
            AdvancedSearchBtn.Click();
            Assert.IsTrue(driver.FindElement(marketPageObject.GetAllGamesBtn()).Displayed);

            
            wait.Until(ExpectedConditions.ElementToBeClickable(marketPageObject.GetAllGamesBtn()));
            var AllGamesBtn = driver.FindElement(marketPageObject.GetAllGamesBtn());
            AllGamesBtn.Click();

            var DotaBtn = driver.FindElement(marketPageObject.GetDotaBtn());
            DotaBtn.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(marketPageObject.GetDotaHeroBtn()));
            var DotaHeroBtn = driver.FindElement(marketPageObject.GetDotaHeroBtn());
            DotaHeroBtn.Click();

            var LifeStealerOption = driver.FindElement(marketPageObject.GetLifeStealerOption());
            LifeStealerOption.Click();

            var RarityImmortalOption = driver.FindElement(marketPageObject.GetRarityImmortalOption());
            RarityImmortalOption.Click();

            var SearchBox = driver.FindElement(marketPageObject.GetSearchBox());
            SearchBox.Click();
            SearchBox.SendKeys("golden");

            var SearchBtn = driver.FindElement(marketPageObject.GetSearchBtn());
            SearchBtn.Click();

            Assert.IsTrue(driver.FindElement(marketPageObject.Get_VerifyDotaCategory()).Displayed);
            Assert.IsTrue(driver.FindElement(marketPageObject.Get_VerifyLifestealerCategory()).Displayed);
            Assert.IsTrue(driver.FindElement(marketPageObject.Get_VerifyImmortalCategory()).Displayed);
            Assert.IsTrue(driver.FindElement(marketPageObject.Get_VerifyGoldenCategory()).Displayed);

            IWebElement element = driver.FindElement(marketPageObject.Get_VerifyGame1());
            string Game1 = element.Text;
            Assert.IsTrue(Game1.Contains("Golden"));

            element = driver.FindElement(marketPageObject.Get_VerifyGame2());
            string Game2 = element.Text;
            Assert.IsTrue(Game1.Contains("Golden"));

            element = driver.FindElement(marketPageObject.Get_VerifyGame3());
            string Game3 = element.Text;
            Assert.IsTrue(Game1.Contains("Golden"));

            element = driver.FindElement(marketPageObject.Get_VerifyGame4());
            string Game4 = element.Text;
            Assert.IsTrue(Game1.Contains("Golden"));

            element = driver.FindElement(marketPageObject.Get_VerifyGame5());
            string Game5 = element.Text;
            Assert.IsTrue(Game1.Contains("Golden"));

            var RemoveGoldenCategory = driver.FindElement(marketPageObject.GetRemoveGoldenCategory());
            RemoveGoldenCategory.Click();

            var RemoveDota2Category = driver.FindElement(marketPageObject.GetRemoveDota2Category());
            RemoveDota2Category.Click();
            Assert.IsFalse(marketPageObject.GoldenCategory());
            string ExpectedFinalItemName = driver.FindElement(marketPageObject.GetVerifyItem1()).Text;

            var FInalGameBtn = driver.FindElement(marketPageObject.GetFinalResultGameBtn());
            FInalGameBtn.Click();
            string ActualFinalItemName = driver.FindElement(marketPageObject.GetVerifyFinalItemName()).Text;
            string ActualFinalItemType = driver.FindElement(marketPageObject.GetVerifyFinalItemType()).Text;
            string ActualFinalGameName = driver.FindElement(marketPageObject.GetVerifyFinalGameName()).Text;
            string ActualFinalHeroType = driver.FindElement(marketPageObject.GetVerifyFinalHeroType()).Text;

            Assert.IsTrue(ExpectedFinalItemName == ActualFinalItemName);
            Assert.IsTrue(ActualFinalItemType.Contains("Immortal"));
            Assert.IsTrue(ActualFinalGameName.Contains("Dota 2"));
            Assert.IsTrue(ActualFinalHeroType.Contains("Lifestealer"));
        }


        [TearDown]
        public void TearDown()
        {

        }
    }
}