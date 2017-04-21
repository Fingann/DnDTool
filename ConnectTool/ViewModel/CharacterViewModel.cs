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
    using DnDTool.Core;
    using DnDTool.Core.Model.Character;
    using DnDTool.Interface;
    using DnDTool.Model.Services;
    using DnDTool.ViewModel.CharacterModels;
    using DnDTool.ViewModel.CharacterModels.AbilityScore;

    using GalaSoft.MvvmLight;

    /// <summary>
    ///     The caller view model.
    /// </summary>
    public class CharacterViewModel : ViewModelBase, INavigationView, IDisplayable
    {
        private AbilityScoresViewModel abilityScoresViewModel;

        private Character character;

        private InfoViewModel infoViewModel;

        private TraitsViewModel traitsViewModel;

        public CharacterViewModel(
            IDataService dataservice,
            INotificationService notificationService,
            INavigationService navigationService)
        {
            this._navigationService = navigationService;
            this._notificationService = notificationService;
            abilityScoresViewModel = new AbilityScoresViewModel();
            InfoViewModel =new InfoViewModel();
            traitsViewModel = new TraitsViewModel();
            // this.DisplayNotificationCommand = new RelayCommand(this.DisplayNotification);
            this._dataService = dataservice;
            this._dataService.GetCharecter(
                (character, exception) =>
                    {
                        if (exception != null) return;

                        this.Character = character;
                        CharacterManager.Instance.Character = this.Character;
                    });
            AbilityScoresViewModel = new AbilityScoresViewModel() {AbilityScores = this.character.AbilityScores};
            InfoViewModel = new InfoViewModel() {Info = this.character.Info};
            TraitsViewModel = new TraitsViewModel() {Traits = character.Traits};
        }

        public IDataService _dataService { get; set; }

        public TraitsViewModel TraitsViewModel
        {
            get
            {
                return this.traitsViewModel;
            }

            set
            {
                this.traitsViewModel = value;
                this.RaisePropertyChanged();
            }
        }

        public AbilityScoresViewModel AbilityScoresViewModel
        {
            get
            {
                return this.abilityScoresViewModel;
            }

            set
            {
                this.abilityScoresViewModel = value;
                this.RaisePropertyChanged();
            }
        }

        public Character Character
        {
            get
            {
                return this.character;
            }

            set
            {
                this.character = value;
                this.RaisePropertyChanged();
            }
        }

        public InfoViewModel InfoViewModel
        {
            get
            {
                return this.infoViewModel;
            }

            set
            {
                this.infoViewModel = value;
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