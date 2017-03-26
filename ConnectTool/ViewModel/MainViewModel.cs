// --------------------------------------------------------------------------------------------------------------------
// <copyright file="mainViewModel.cs" company="BKK">
// </copyright>
// <summary>
//   This class contains properties that the main View can data bind to.
//   <para>
//   See http://www.mvvmlight.net
//   </para>
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using System.Windows;
using DnDTool.Model.Services;
using DnDTool.Resources.Settings;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MahApps.Metro.Controls.Dialogs;

namespace DnDTool.ViewModel
{
    /// <summary>
    ///     The main view model.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        //Services
        private readonly IDataService dataService;

        /// <summary>
        ///     Initializes a new instance of the mainViewModel class.
        /// </summary>
        /// <param name="dataService">
        ///     The data Service.
        /// </param>
        public MainViewModel(IDataService dataService, IDialogCoordinator dialogCoordinator,
            INavigationService navigationService)
        {
            // ViewSetup, Sort INavigationViews
            this.dataService = dataService;
            _navigationService = navigationService;
            _dialogCoordinator = dialogCoordinator;
            OnLoadedCommand = new RelayCommand(OnLoaded);
        }

        public INavigationService _navigationService { get; set; }
        private IDialogCoordinator _dialogCoordinator { get; }


        public RelayCommand OnLoadedCommand { get; private set; }


        private async void OnLoaded()
        {
            _navigationService.NavigateToStartPage();

            //await this.Login();
        }

        private async Task Login()
        {
            while (true)
            {
                var dictionary = new ResourceDictionary();
                dictionary.Source =
                    new Uri(
                        "pack://application:,,,/MaterialDesignThemes.MahApps;component/Themes/MaterialDesignTheme.MahApps.Dialogs.xaml");
                var result =
                    await
                        _dialogCoordinator.ShowLoginAsync(
                            this,
                            "Login",
                            string.Empty,
                            new LoginDialogSettings
                            {
                                InitialUsername = UserSettings.Default.Username,
                                EnablePasswordPreview = true,
                                UsernameWatermark = "s_user",
                                PasswordWatermark = "Password",
                                AnimateHide = true,
                                SuppressDefaultResources = false,
                                CustomResourceDictionary = dictionary
                            });

                // user exits
                if (result == null)
                {
                    Application.Current.MainWindow.Close();
                    return;
                }

                // HEr vil det komme validation mot AD. 
                if (result.Username != "steffen") continue;

                // check to se if we should save password. 
                UserSettings.Default.Username = result.Username;

                UserSettings.Default.Save();

                break;
            }
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();

        ////}
    }
}