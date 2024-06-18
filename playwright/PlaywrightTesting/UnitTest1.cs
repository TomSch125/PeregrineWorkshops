using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Text.RegularExpressions;

namespace PlaywrightTesting
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public async Task Test1()
        {
            // Create Playwright
            using var playwright = await Playwright.CreateAsync();
            // Create browser
            await using var browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500,
                Timeout = 8000
            });

            // Create context
            var context = await browser.NewContextAsync(new BrowserNewContextOptions()
            {
                RecordVideoDir = "video\\vid1.mp3",
                RecordVideoSize = new RecordVideoSize()
                {
                    Width = 1920,
                    Height = 1080
                },
                ViewportSize = new ViewportSize()
                {
                    Width = 1920,
                    Height = 1080
                }
            });

            // Create Page
            var page = await context.NewPageAsync();
            // Set viewport for maximum window size
            await page.SetViewportSizeAsync(1920, 1080);
            // Open the search engine
            await page.GotoAsync("https://www.google.com/");
            await page.WaitForLoadStateAsync();

            // Dismiss any cookies dialog
            IElementHandle? element = await page.QuerySelectorAsync("text='Accept all'");
            if (element is not null)
            {
                await element.ClickAsync();
                await element.WaitForElementStateAsync(ElementState.Hidden);
                await Task.Delay(TimeSpan.FromSeconds(2.0));
            }

            // Search for the desired term
            await page.TypeAsync("[name='q']", ".net core");
            await page.Keyboard.PressAsync("Enter");
            // Wait for the results to load
            await page.WaitForSelectorAsync("id=appbar");

            // Click through to the desired result
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots\\Net2.png" });
            await page.ClickAsync("a:has-text('.NET')");
            await Task.Delay(TimeSpan.FromSeconds(2.0));

            IElementHandle? button = await page.QuerySelectorAsync("text='Accept'");
            if (button is not null)
            {
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots\\Net3.png" });
                await button.ClickAsync();
                await Task.Delay(TimeSpan.FromSeconds(2.0));
            }

            await Task.Delay(TimeSpan.FromSeconds(2.0));
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots\\Net4.png" });
            await page.SetViewportSizeAsync(1920, 1080);
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots\\Net5.png" });
            await Task.Delay(TimeSpan.FromSeconds(5.0));

            var isExist = await page.Locator(selector: "text='Performance'").IsVisibleAsync();
            Assert.That(isExist, Is.False);
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots\\Net6.png" });
            await Task.Delay(TimeSpan.FromSeconds(5.0));
            await context.CloseAsync();
        }
    }
}
