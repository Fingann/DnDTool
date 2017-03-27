// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CallerViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CallerViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using DnDTool.Interface;
using DnDTool.Model.Services;
using GalaSoft.MvvmLight.CommandWpf;

namespace DnDTool.ViewModel
{
    /// <summary>
    /// The caller view model.
    /// </summary>
    public class CharacterViewModel: INavigationView, IDisplayable
    {
        public RelayCommand DisplayNotificationCommand { get; private set; }

        private INotificationService _notificationService { get; set; }

        private INavigationService _navigationService { get; set; }

        public CharacterViewModel(INotificationService notificationService, INavigationService navigationService)
        {
            _navigationService = navigationService;
            _notificationService = notificationService;
            this.DisplayNotificationCommand = new RelayCommand(this.DisplayNotification);
        }

        private void DisplayNotification()
        {
            _navigationService.NavigateTo("Inventory");


            _notificationService.ShowMessage("Changing to Login View", "You have changed! ", "WindowArea",null,
                () =>
                    {
                        _notificationService.Exception(new AccessViolationException("bla bla testse8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269"), "WindowArea");
                    });
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; } = "Charecter View";

        public object Parameter { get; set; }
    }
}
