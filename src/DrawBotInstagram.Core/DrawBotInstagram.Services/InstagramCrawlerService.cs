using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DrawBotInstagram.Models;
using DrawBotInstagram.Models.Settings;
using DrawBotInstagram.Services.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DrawBotInstagram.Services
{
    public class InstagramCrawlerService : IInstagramCrawlerService
    {
        private IWebDriver _driver;

        private readonly InstagramUserSettings _instagramUser;
        private readonly SeleniumDriverSettings _seleniumDriverSettings;
        
        private const int SECONDS_WAIT_LOAD = 20;
        
        public InstagramCrawlerService(InstagramUserSettings instagramUser, SeleniumDriverSettings seleniumDriverSettings)
        {
            _instagramUser = instagramUser;
            _seleniumDriverSettings = seleniumDriverSettings;
        }

        public void FactoryDriver()
        {
            _driver = string.IsNullOrEmpty(_seleniumDriverSettings.DriverFolder)
            ? new ChromeDriver()
            : new ChromeDriver(Path.Combine(Directory.GetCurrentDirectory(), _seleniumDriverSettings.DriverFolder));

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(SECONDS_WAIT_LOAD);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(SECONDS_WAIT_LOAD);
        }

        public void InstagramLogin()
        {                
            _driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");
            
            _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div/div[1]/div/label/input")).SendKeys(_instagramUser.User);
            _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div/div[2]/div/label/input")).SendKeys(_instagramUser.Password);
            _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div/div[3]/button")).Submit();
        }

        public void EnterPromotion()
        {
            _driver.Navigate().GoToUrl(_instagramUser.PromotionLink);
            
            var page = _driver.CurrentWindowHandle;
            _driver.SwitchTo().Window(page); 
        }

        public bool IsLoggedInInstagram()
        {
            return true;
        }

        public void PublishCommentUsersProfile(IList<InstagramUser> instagramUsers)
        {
            var skip = 0;
            
            while (skip < instagramUsers.Count)
            {
                var take = (int)_instagramUser.PersonPerComment;
                
                var users = instagramUsers.Skip(skip).Take(take);

                if (users.Any())
                {
                    CommentUserProfile(users);

                    skip  += take;
                }
                else
                {
                    skip = instagramUsers.Count;
                }    
            }
        }

        private void CommentUserProfile(IEnumerable<InstagramUser> users)
        {
            _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form")).Click();
                
            var textAreaElement = _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/textarea"));            
            
            foreach (var user in users)
            {
                textAreaElement.SendKeys($"{user.UserName} ");
            }

            _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/button")).Submit();
        }

        public void CloseDisposeDriver()
        {
            if (_driver != null)
            {
                _driver.Close();
                _driver.Dispose();
            }
        }
    }
}