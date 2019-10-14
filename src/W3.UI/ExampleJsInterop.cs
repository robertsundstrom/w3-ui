using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace W3.UI
{
    public class ExampleJsInterop
    {
        public static async Task<string> Prompt(IJSRuntime jsRuntime, string message)
        {
            // Implemented in exampleJsInterop.js
            return await jsRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
