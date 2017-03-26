using System;

namespace DnDTool.Model.Services
{
    public interface INotificationService
    {
        void Exception(
            Exception ex,
           string areaName = "", TimeSpan? expirationTime = default(TimeSpan?), Action onClick = null, Action onClose = null);

        void ShowMessage(
            string title,
            string message,
           string areaName = "", TimeSpan? expirationTime = default(TimeSpan?), Action onClick = null, Action onClose = null);

        void Warning(
            string title,
            string message,
            string areaName = "", TimeSpan? expirationTime = default(TimeSpan?), Action onClick = null, Action onClose = null);

        void Success(
           string title,
           string message,
          string areaName = "", TimeSpan? expirationTime = default(TimeSpan?), Action onClick = null, Action onClose = null);
    }
}