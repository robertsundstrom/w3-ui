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

        public Task<string> Prompt(string message)
        {
            // Implemented in exampleJsInterop.js
            return jsRuntime.InvokeAsync<string>(
                "browserInterop.showPrompt",
                message);
        }

        public Task<string> GetDocumentTitle()
        {
            return jsRuntime.InvokeAsync<string>("browserInterop.getDocumentTitle");
        }

        public Task SetDocumentTitle(string value)
        {
            return jsRuntime.InvokeAsync<object>("browserInterop.setDocumentTitle", value);
        }

        public Task ScrollToTop()
        {
            return jsRuntime.InvokeAsync<object>("browserInterop.scrollToTop");
        }

        public Task Navigate(Uri uri, bool newTab = false)
        {
            return jsRuntime.InvokeAsync<object>("browserInterop.navigate", uri.ToString(), newTab);
        }
    }
}
