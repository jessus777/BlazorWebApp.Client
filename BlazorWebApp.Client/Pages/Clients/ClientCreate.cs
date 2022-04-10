using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWebApp.Client.Pages.Clients
{
    public partial class ClientCreate
    {
        [Inject] public IJSRuntime JsRuntime { get; set; }
        private string DateSelect;

        protected override async Task OnInitializedAsync()
        {
            //forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            //await JsRuntime.InvokeVoidAsync("Select2demo");
        }

        protected async Task InputMaskPhoneClick()
        {
            await JsRuntime.InvokeVoidAsync("InputPhoneMask");
        }

        protected async Task SelectDate()
        {
             await JsRuntime.InvokeVoidAsync("DateSelect");
        }

        protected async Task Select2Demo()
        {
            await JsRuntime.InvokeVoidAsync("Select2demo");
        }
    }
}
