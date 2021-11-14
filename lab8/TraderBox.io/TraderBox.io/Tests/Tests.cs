using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using System.Threading.Tasks;

namespace TraderBox.io
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        //private string driverPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + @"\TraderBox.io\ChromeDriver\Windows\";
        private string driverPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "/TraderBox.io/ChromeDriver/Linux/";
        private const string testEmail = "forepamtesting@mail.ru";
        private const string testPassword = "passwordis12345";
        private const int testValueForDots = 5;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless", "--disable-gpu", "--window-size=1920,1200",
                "--ignore-certificate-errors", "--disable-extensions", "--no-sandbox", "--disable-dev-shm-usage");
            driver = new ChromeDriver(driverPath, chromeOptions);
            driver.Navigate().GoToUrl("https://traderbox.io/demo");
            driver.Manage().Window.Maximize();

            var logInBtn = driver.FindElement(By.XPath("//a[@class = 'button button_white w-button js-auth-btn']"));
            logInBtn.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var inputEmail = wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id = 'loginform-identifier']")));
            inputEmail.SendKeys(testEmail);
            var inputPassword = driver.FindElement(By.XPath("//input[@id = 'loginform-password']"));
            inputPassword.SendKeys(testPassword);
            var submitBtn = driver.FindElement(By.XPath("//button[@name = 'login-button']"));
            submitBtn.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var closeWindowWithMessageAboutSettingUpTwoFactorAuthentication = wait.Until(ExpectedConditions.
                ElementToBeClickable(By.XPath("//div[@class = 'el-dialog__wrapper traderbox-dialog modal-mfa-notify coinup']" +
                "//i[@class = 'el-dialog__close el-icon el-icon-close']")));
            closeWindowWithMessageAboutSettingUpTwoFactorAuthentication.Click();

        }

        [Test]
        public void BuyPolkadotsTest()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            var viewCoinsOfDemoAcc = wait.Until(ExpectedConditions.
                ElementToBeClickable(By.XPath("//div[@class = 'group']/div[@class = 'title primary-text']")));
            viewCoinsOfDemoAcc.Click();
            

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            string startNumberOfDots = wait.Until(ExpectedConditions.
                ElementExists(By.
                XPath("//span[contains(text(),'DOT') and @class = 'title primary-text']/ancestor::tr//span[@class = 'primary-text']"))).Text;
            int dotIndex = startNumberOfDots.IndexOf(".");
            string startNumberOfDotsBeforeDotIndex = startNumberOfDots.Substring(0, dotIndex);
            string expectedNumberOfDots = Convert.ToString(Convert.ToInt32(startNumberOfDotsBeforeDotIndex) + testValueForDots);


            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var searchForAllPolkadotTradingPairs = wait.Until(ExpectedConditions.
                ElementExists(By.XPath("//div[@class = 'input']//input[@type = 'text']")));
            searchForAllPolkadotTradingPairs.SendKeys("dot");

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(240));
            var chooseDotBtcTradingPair = wait.Until(ExpectedConditions.
                ElementToBeClickable(By.XPath("//div[@class = 'ticker primary-text']//span[contains(text(),'DOT/BTC')]")));
            chooseDotBtcTradingPair.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(240));
            var inputNumberOfDots = wait.Until(ExpectedConditions.
                ElementExists(By.XPath("//div[@class = 'order-tab']//div[@class = 'quantity-block']//input[@type = 'text']")));
            inputNumberOfDots.SendKeys(Convert.ToString(testValueForDots));

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var submitCurrnecyExchangeBtn = wait.Until(ExpectedConditions.
                ElementToBeClickable(By.XPath("//div[@class = 'footer primary-bg light']/div[@class = 'button green']")));
            submitCurrnecyExchangeBtn.Click();
            

            Task.Delay(5000).Wait();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var finishNumberOfDots = wait.Until(ExpectedConditions.
                ElementExists(By.
                XPath("//span[contains(text(),'DOT') and @class = 'title primary-text']/ancestor::tr//span[@class = 'primary-text']"))).Text;
            dotIndex = finishNumberOfDots.IndexOf(".");
            string finishNumberOfDotsBeforeDotIndex = finishNumberOfDots.Substring(0, dotIndex);


            Assert.AreEqual(expectedNumberOfDots, finishNumberOfDotsBeforeDotIndex);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}