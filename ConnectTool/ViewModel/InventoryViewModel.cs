// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginViewModel.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the LoginViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using DnDTool.Interface;
using DnDTool.Model.Services;
using GalaSoft.MvvmLight.CommandWpf;
using MahApps.Metro.Controls.Dialogs;

namespace DnDTool.ViewModel
{
    /// <summary>
    /// The login view model.
    /// </summary>
    public class InventoryViewModel : IDisplayable
    {
        public RelayCommand DisplayMessageCommand { get; private set; }

        public INavigationService NavigationService { get; set; }
        public InventoryViewModel(IDialogCoordinator dialogCoordinator, INavigationService nav)
        {
            NavigationService = nav;
            _dialogCoordinator = dialogCoordinator;
            this.DisplayMessageCommand = new RelayCommand(this.DisplayMessage);

        }

        private IDialogCoordinator _dialogCoordinator { get; set; }

        private async void DisplayMessage()
        {
          NavigationService.NavigateTo("Inventory");
        }

        /// <summary>
        /// The text.
        /// </summary>
        private string text = string.Empty;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value;
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; } = "Login View";

        public object Parameter { get; set; }
    }
}