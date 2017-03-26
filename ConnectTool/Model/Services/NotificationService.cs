using System;
using Notifications.Wpf;

namespace DnDTool.Model.Services
{
    public class NotificationService : INotificationService
    {
        private readonly NotificationManager _notificationManager = new NotificationManager() ;


        public void Exception(
            Exception ex,
            string areaName = "",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {

            var content = new NotificationContent
            {
                Title = ex.GetType().FullName,
                Message = ex.Message,
                Type = NotificationType.Error
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }

        public void ShowMessage(
            string title,
            string message,
            string areaName = "",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {
            var content = new NotificationContent
            {
                Title = title,
                Message = message,
                Type = NotificationType.Information
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }

        public void Warning(
            string title,
            string message,
            string areaName = "",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {
            var content = new NotificationContent
            {
                Title = title,
                Message = message,
                Type = NotificationType.Warning
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }

        public void Success(
            string title,
            string message,
            string areaName = "",
            TimeSpan? expirationTime = null,
            Action onClick = null,
            Action onClose = null)
        {
            var content = new NotificationContent
            {
                Title = title,
                Message = message,
                Type = NotificationType.Warning
            };
            _notificationManager.Show(content, areaName, expirationTime, onClick, onClose);
        }
    }
}
