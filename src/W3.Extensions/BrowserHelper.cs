using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace W3.Extensions
{
    public class BrowserHelper
    {
        IJSRuntime jsRuntime;
        
        public BrowserHelper(IJSRuntime jsRuntime) 
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task<string> Prompt(string message)
        {
            // Implemented in exampleJsInterop.js
            return await jsRuntime.InvokeAsync<string>(
                "browserInterop.showPrompt",
                message);
        }

        public async Task<string> GetDocumentTitle()
        {
            return await jsRuntime.InvokeAsync<string>("browserInterop.getDocumentTitle");
        }

        public async Task SetDocumentTitle(string value)
        {
            await jsRuntime.InvokeAsync<object>("browserInterop.setDocumentTitle", value);
        }

        public async Task ScrollToTop()
        {
            await jsRuntime.InvokeAsync<object>("browserInterop.scrollToTop");
        }

        public async Task Navigate(Uri uri, bool newTab = false)
        {
            await jsRuntime.InvokeAsync<object>("browserInterop.navigate", uri.ToString(), newTab);
        }
    }
}
