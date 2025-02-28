using Microsoft.AspNetCore.Components;

namespace BlazorWasmEyeRevealApp.Pages;

public class CoreComponentBase: ComponentBase
{
    protected string? PasswordType { get; private set; } = "password";
    protected string? ConfirmPasswordType { get; private set; } = "password";
    protected string CssClassPasswordEyeIcon { get; private set; } = "bi-eye-icon";
    protected string CssClassConfirmPasswordEyeIcon { get; private set; } = "bi-eye-icon";
    protected void TogglePasswordReveal() => ToggleEyeIcon("password");
    protected void ToggleConfirmPasswordReveal() => ToggleEyeIcon("confirm-password");

    private void ToggleEyeIcon(string element)
    {
        switch (element)
        {
            case "password":
                CssClassPasswordEyeIcon = PasswordType == "password" ? "bi-eye-icon-slash" : "bi-eye-icon";
                PasswordType = PasswordType == "password" ? "text" : "password";
                
                break;
            case "confirm-password":
                CssClassConfirmPasswordEyeIcon = ConfirmPasswordType == "password" ? "bi-eye-icon-slash" : "bi-eye-icon";
                ConfirmPasswordType = ConfirmPasswordType == "password" ? "text" : "password";
                break;
        }
    }
}