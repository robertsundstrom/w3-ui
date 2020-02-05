using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;

namespace W3.UI.Showcase
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
