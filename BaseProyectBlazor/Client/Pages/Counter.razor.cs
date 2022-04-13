using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using static BaseProyectBlazor.Client.Shared.MainLayout;

namespace BaseProyectBlazor.Client.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject] protected ServicesSingleton Singleton { get; set; }
        [Inject] protected ServicesTransient Transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }
        [CascadingParameter] protected  AppState appState { get; set; }

        IJSObjectReference module;

        protected int currentCount = 0;
        static int currentCountStatic = 0;


        [JSInvokable]
        public async Task IncrementCount()
        {
            module = await JS.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await module.InvokeVoidAsync("showAlert");

            currentCount++;
            Singleton.Value = currentCount;
            Transient.Value = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("testPointNetStatic");
        }

        protected async Task IncrementCountJavascript()
        {
            await JS.InvokeVoidAsync("testPointNETInstancia",
                DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
