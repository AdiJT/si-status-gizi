using StatusGizi.Web.Models;

namespace StatusGizi.Web.Services.Contracts;

public interface IToastrNotificationService
{
    string? GetNotificationJson();
    void AddNotification(ToastrNotification notification);
    void AddSuccess(string message, string? title = null, ToastrOptions? options = null);
    void AddInfo(string message, string? title = null, ToastrOptions? options = null);
    void AddWarning(string message, string? title = null, ToastrOptions? options = null);
    void AddError(string message, string? title = null, ToastrOptions? options = null);
}
