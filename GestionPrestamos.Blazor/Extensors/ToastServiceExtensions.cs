using BlazorBootstrap;
namespace GestionPrestamos.Extensors;

public static class ToastServiceExtensions
{
    // Generalized method to show any type of toast
    public static ToastMessage ShowToast(this ToastService toastService, ToastType toastType, string title, string customMessage = null) {
        var message = new ToastMessage() {
            Type = toastType,
            Title = title,
            Message = customMessage ?? $"A las {DateTime.Now.ToString("hh:mm tt")}"
        };
        toastService.Notify(message);
        return message;
    }

    // ShowSuccess method
    public static ToastMessage ShowSuccess(this ToastService toastService, string title = "Success", string customMessage = null) {
        return toastService.ShowToast(ToastType.Success, title, customMessage);
    }

    // ShowWarning method
    public static ToastMessage ShowWarning(this ToastService toastService, string title = "Warning", string customMessage = null) {
        return toastService.ShowToast(ToastType.Warning, title, customMessage);
    }

    // ShowError method
    public static ToastMessage ShowError(this ToastService toastService, string title = "Error", string customMessage = null) {
        return toastService.ShowToast(ToastType.Danger, title, customMessage);
    }

}
