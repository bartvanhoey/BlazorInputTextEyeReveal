using BlazorWasmEyeRevealApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorWasmEyeRevealApp.Pages;

public class RegisterBase : CoreComponentBase
{
    [SupplyParameterFromForm] protected RegisterInputModel Model { get; set; } = new();
    [SupplyParameterFromQuery] protected string? ReturnUrl { get; set; }

    public async Task RegisterUserAsync(EditContext editContext)
    {
        await Task.CompletedTask;
    }
}