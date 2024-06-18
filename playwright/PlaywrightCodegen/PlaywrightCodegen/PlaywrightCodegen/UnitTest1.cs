using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework.Interfaces;
using System;
using System.Threading.Tasks;

namespace PlaywrightCodegen
{
    public class Tests: PageTest
    {

        [Test]
        public async Task MyTest()
        {
            var context = await Browser.NewContextAsync(new BrowserNewContextOptions()
            {
                RecordVideoDir = "video\\Oranges.mp3",
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
            var Page = await context.NewPageAsync();

            await Page.SetViewportSizeAsync(1920, 1080);

            await Page.GotoAsync("http://localhost:50294/Product");

            int PreCount = 0;
            foreach (var li in await Page.Locator("tr > td").AllAsync())
                if (await li.InnerTextAsync() == "Oranges")
                {
                    PreCount++;
                }

            await Page.GetByRole(AriaRole.Link, new() { Name = "Create New" }).ClickAsync();
            await Page.GetByLabel("product name").ClickAsync();
            await Page.GetByLabel("product name").PressAsync("CapsLock");
            await Page.GetByLabel("product name").FillAsync("O");
            await Page.GetByLabel("product name").PressAsync("CapsLock");
            await Page.GetByLabel("product name").FillAsync("Oranges");
            await Page.GetByLabel("Price").ClickAsync();
            await Page.GetByLabel("Price").FillAsync("10.00");
            await Page.GetByLabel("description").ClickAsync();
            await Page.GetByLabel("description").PressAsync("CapsLock");
            await Page.GetByLabel("description").FillAsync("J");
            await Page.GetByLabel("description").PressAsync("CapsLock");
            await Page.GetByLabel("description").FillAsync("sweet oranges");
            await Page.GetByRole(AriaRole.Button, new() { Name = "Create" }).ClickAsync();

            await Page.GotoAsync("http://localhost:50294/Product");

            // Looks for any instace of Orange to prove it was added
            int count = 0;
            foreach (var li in await Page.Locator("tr > td").AllAsync())
                if (await li.InnerTextAsync() == "Oranges")
                {
                    count++;
                }
            Assert.Greater(count, 0);
        }

        [Test]
        public async Task MyTestApple()
        {

            //var page = await Context.NewPageAsync().ConfigureAwait(false);
            var context = await Browser.NewContextAsync(new BrowserNewContextOptions()
            {
                RecordVideoDir = "video\\Apple.mp3",
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
            var page = await context.NewPageAsync();

            await page.SetViewportSizeAsync(1920, 1080);

            await page.GotoAsync("http://localhost:50294/Product");

            int PreCount = 0;
            foreach (var li in await page.Locator("tr > td").AllAsync())
                if (await li.InnerTextAsync() == "Apple")
                {
                    PreCount++;
                }

            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots/BeforeApple.png" });
            await page.GetByRole(AriaRole.Link, new() { Name = "Create New" }).ClickAsync();
            await page.GetByLabel("product name").ClickAsync();
            await page.GetByLabel("product name").PressAsync("CapsLock");
            await page.GetByLabel("product name").FillAsync("A");
            await page.GetByLabel("product name").PressAsync("CapsLock");
            await page.GetByLabel("product name").FillAsync("Apple");
            await page.GetByLabel("Price").ClickAsync();
            await page.GetByLabel("Price").FillAsync("1.0");
            await page.GetByLabel("description").ClickAsync();
            await page.GetByLabel("description").PressAsync("CapsLock");
            await page.GetByLabel("description").FillAsync("G");
            await page.GetByLabel("description").PressAsync("CapsLock");
            await page.GetByLabel("description").FillAsync("Granny ");
            await page.GetByLabel("description").PressAsync("CapsLock");
            await page.GetByLabel("description").FillAsync("Granny S");
            await page.GetByLabel("description").PressAsync("CapsLock");
            await page.GetByLabel("description").FillAsync("Granny Smith");
            await page.GetByRole(AriaRole.Button, new() { Name = "Create" }).ClickAsync();
            await page.Locator("html").ClickAsync();
            await page.GotoAsync("http://localhost:50294/Product");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "Screenshots/AfterApple.png" });
            // Looks for any instace of apple to prove it was added
            int count = 0;
            foreach (var li in await page.Locator("tr > td").AllAsync())
                if (await li.InnerTextAsync() == "Apple") {
                    count++;
                }
            Assert.Greater(count, PreCount);

            //var item = page.Locator("tr:nth-child(9) > td").First;
            //Assert.AreEqual("Apple", await item.InnerTextAsync());

        }
    }
}
