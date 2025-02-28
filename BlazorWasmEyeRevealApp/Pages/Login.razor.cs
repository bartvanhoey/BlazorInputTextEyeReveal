using BlazorWasmEyeRevealApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmEyeRevealApp.Pages;

public class LoginBase : CoreComponentBase
{
    [Parameter] public bool IsVisible { get; set; }
    [SupplyParameterFromQuery] protected string? ReturnUrl { get; set; }
    [SupplyParameterFromForm] protected LoginInputModel Input { get; set; } = new();
    
    protected async Task LoginUserAsync()
    {
        await Task.CompletedTask;
    }


}