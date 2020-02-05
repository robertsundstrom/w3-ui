using Microsoft.AspNetCore.Blazor.Hosting;

namespace BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var hostBuilder = WebAssemblyHostBuilder.CreateDefault();
            hostBuilder.RootComponents.Add<App>("app");
            await hostBuilder.Build().RunAsync();
        }
    }
}
