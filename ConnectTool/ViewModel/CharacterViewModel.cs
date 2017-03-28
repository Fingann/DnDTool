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
using DnDTool.Model.Character;
using GalaSoft.MvvmLight.CommandWpf; 
      

namespace DnDTool.ViewModel
{
    using System.Runtime.CompilerServices;

    using DnDTool.Views.CharecterViews;

    using GalaSoft.MvvmLight;

    /// <summary>
    /// The caller view model.
    /// </summary>
    public class CharacterViewModel: ViewModelBase, INavigationView, IDisplayable
    {
        //public RelayCommand DisplayNotificationCommand { get; private set; }

        private INotificationService _notificationService { get; set; }

        private INavigationService _navigationService { get; set; }
        
        public IDataService _dataService { get; set; }

        public CharacterViewModel(IDataService dataservice, INotificationService notificationService, INavigationService navigationService)
        {
            _navigationService = navigationService;
            _notificationService = notificationService;
            //this.DisplayNotificationCommand = new RelayCommand(this.DisplayNotification);

             _dataService = dataservice;
            _dataService.GetCharecter(((character, exception) =>
                                             {
                                                 if (exception != null) return;

                                                 Character = character;
                                             }));
        }

        

    
        private Character charecter;

        private Info charecterInfo = new Info();

        private AbilityScores charecterAbilityScores;

        public Character Character
        {
            get
            {
                return this.charecter;
            }
            set
            {
                charecter = value;
                this.charecterInfo = value.Info;
                this.RaisePropertyChanged("CharecterInfo");

                this.CharecterAbilityScores = value.AbilityScores;
                this.RaisePropertyChanged("CharecterAbilityScores");

                this.RaisePropertyChanged();

            } 
        }

        public Info CharecterInfo
        {
            get
            {
                return this.charecterInfo;
            }
            set
            {
                this.charecterInfo = value;
                this.RaisePropertyChanged();
            }
        }

        public AbilityScores CharecterAbilityScores
        {
            get
            {
                return this.charecterAbilityScores;
            }
            set
            {
                this.charecterAbilityScores = value;
                this.RaisePropertyChanged();
            }
        }

        //private void DisplayNotification()
        //{
        //    _navigationService.NavigateTo("Inventory");


        //    _notificationService.ShowMessage("Changing to Login View", "You have changed! ", "WindowArea",null,
        //        () =>
        //            {
        //                _notificationService.Exception(new AccessViolationException("bla bla testse8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269se8269"), "WindowArea");
        //            });
        //}

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; } = "Charecter View";

        public object Parameter { get; set; }
    }
}
