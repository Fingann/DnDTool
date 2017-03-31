// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CallerViewModel.cs" company="">
// </copyright>
// <summary>
//   Defines the CallerViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable StyleCop.SA1600

namespace DnDTool.ViewModel
{
    using DnDTool.Interface;
    using DnDTool.Model.Character;
    using DnDTool.Model.Services;

    using GalaSoft.MvvmLight;

    /// <summary>
    ///     The caller view model.
    /// </summary>
    public class CharacterViewModel : ViewModelBase, INavigationView, IDisplayable
    {
        private Character character;

        private AbilityScores characterAbilityScores;

        private Info characterInfo = new Info();

        public CharacterViewModel(
            IDataService dataservice,
            INotificationService notificationService,
            INavigationService navigationService)
        {
            this._navigationService = navigationService;
            this._notificationService = notificationService;

            // this.DisplayNotificationCommand = new RelayCommand(this.DisplayNotification);
            this._dataService = dataservice;
            this._dataService.GetCharecter(
                (character, exception) =>
                    {
                        if (exception != null) return;

                        this.Character = character;
                    });
        }

        public IDataService _dataService { get; set; }

        public Character Character
        {
            get
            {
                return this.character;
            }

            set
            {
                this.character = value;
                this.characterInfo = value.Info;
                this.RaisePropertyChanged("CharacterInfo");

                this.CharacterAbilityScores = value.AbilityScores;
                this.RaisePropertyChanged("CharacterAbilityScores");

                this.RaisePropertyChanged();
            }
        }

        public AbilityScores CharacterAbilityScores
        {
            get
            {
                return this.characterAbilityScores;
            }

            set
            {
                this.characterAbilityScores = value;
                this.RaisePropertyChanged();
            }
        }

        public Info CharacterInfo
        {
            get
            {
                return this.characterInfo;
            }

            set
            {
                this.characterInfo = value;
                this.RaisePropertyChanged();
            }
        }

        public object Parameter { get; set; }

        // private void DisplayNotification()
        // {
        // _navigationService.NavigateTo("Inventory");

        // _notificationService.ShowMessage("Changing to Login View", "You have changed! ", "WindowArea",null,
        // () =>
        // {
        // _notificationService.Exception(new AccessViolationException("bla bla testse8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269"), "WindowArea");
        // });
        // }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        public string Title { get; set; } = "Character View";

        private INavigationService _navigationService { get; set; }

        // public RelayCommand DisplayNotificationCommand { get; private set; }
        private INotificationService _notificationService { get; set; }
    }
}