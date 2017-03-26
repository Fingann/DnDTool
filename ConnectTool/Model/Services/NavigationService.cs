// ReSharper disable StyleCop.SA1600

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DnDTool.Interface;
using DnDTool.ViewModel;
using GalaSoft.MvvmLight;
using MahApps.Metro.Controls.Dialogs;

namespace DnDTool.Model.Services
{
    public class NavigationService : ViewModelBase, INavigationService
    {
        private IDisplayable currentViewValue;

        private Dictionary<string, IDisplayable> menuList = new Dictionary<string, IDisplayable>();

        public NavigationService()
        {
            this.ViewList = new Dictionary<string, IDisplayable>
                                {
                                        { "Charecter", new CharacterViewModel(new NotificationService(), null) },
                                        { "Inventory", new InventoryViewModel(new DialogCoordinator(), null) }
                                };
            this.currentViewValue = this.ViewList.First().Value;
        }

        public string CurrentViewKey { get; private set; }

        public IDisplayable CurrentView
        {
            get
            {
                return this.currentViewValue;
            }

            set
            {
                this.currentViewValue = value;
                this.RaisePropertyChanged();
            }
        }

        public string CurrentViewIdentifier
        {
            get
            {
                return ViewList.First(x => x.Value == CurrentView).Key;
            } 
        }

        /// <summary>
        ///     Gets or sets the navigation list.
        /// </summary>
        public Dictionary<string, IDisplayable> MenuList
        {
            get
            {
                return this.GetMenuViews();
            }
        }

        public Stack<string> ViewStack { get; set; } = new Stack<string>(5);

   
        /// <summary>
        ///     The view list.
        /// </summary>
        private Dictionary<string, IDisplayable> ViewList { get; }

        public List<string> GetDisplayableViews()
        {
            return new List<string>(this.ViewList.Keys);
        }

        public Dictionary<string, IDisplayable> GetMenuViews()
        {
            return this.ViewList.Where(x => x.Value is INavigationView)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public void GoBack()
        {
            var lastView = this.ViewStack.Pop();
            this.SetView(lastView);
        }

        public void NavigateTo(string viewIdentifier)
        {
            this.SetView(viewIdentifier);
            this.ViewStack.Push(viewIdentifier);
        }

        public void NavigateTo(string viewIdentifier, object parameter)
        {
            this.ViewList[viewIdentifier].Parameter = parameter;
            this.ViewStack.Push(viewIdentifier);
            
        }

       

        public void NavigateToStartPage()
        {
            var defaultView = this.ViewList.First();
            this.SetView(defaultView.Key);
            this.ViewStack.Push(defaultView.Key);
        }

    
        private void SetView(string viewIdentifier)
        {
            

           
            this.CurrentView = ViewList[viewIdentifier];
        }
    }
}