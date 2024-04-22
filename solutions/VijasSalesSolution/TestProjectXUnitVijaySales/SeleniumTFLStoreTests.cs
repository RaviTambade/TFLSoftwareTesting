using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace VijaySales.Tests
{
    public class SeleniumTests
    {
        [Fact]
        public void GoogleSearchTest()
        {
            //Selenium Web Driver for Chrom download link
            //https://storage.googleapis.com/chrome-for-testing-public/123.0.6312.122/win32/chromedriver-win32.zip

            // Set the path to the ChromeDriver executable
            var chromeDriverPath = @"D:\tryout\chromedriver\chromedriver.exe"; // Update with your actual path

            // Initialize the Chrome driver
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless"); // Optional: run Chrome in headless mode
            using (var driver = new ChromeDriver(chromeDriverPath, chromeOptions))
            {
                // Navigate to Google
                driver.Navigate().GoToUrl("http://localhost:8000/");
                driver.Manage().Window.Size = new System.Drawing.Size(1366, 728);
                driver.FindElement(By.LinkText("Gallery")).Click();
                driver.FindElement(By.Id("1")).Click();
                driver.FindElement(By.CssSelector("button")).Click();
                driver.FindElement(By.CssSelector("tr:nth-child(2)")).Click();
                driver.FindElement(By.Id("txtquantity")).SendKeys("45");
                driver.FindElement(By.CssSelector("td:nth-child(1) > input")).Click();

                // Assert that the page title contains the search term
                Assert.Contains("Transflower Store", driver.Title);
            }
        }
    }
}
