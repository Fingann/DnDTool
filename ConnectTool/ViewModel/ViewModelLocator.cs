/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:ConnectTool.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using DnDTool.Model.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Practices.ServiceLocation;

namespace DnDTool.ViewModel
{
   

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes static members of the <see cref="ViewModelLocator"/> class.
        /// </summary>
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            


            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }
            SimpleIoc.Default.Register<IDialogCoordinator, DialogCoordinator>();
            SimpleIoc.Default.Register<INotificationService, NotificationService>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();

            //true instansiates it right away
            //SimpleIoc.Default.Register<AbilityScoresViewModel>(true);
            SimpleIoc.Default.Register<MainViewModel>(true);
            SimpleIoc.Default.Register<CharacterViewModel>(true);
            SimpleIoc.Default.Register<BackgroundViewModel>(true);

            //SimpleIoc.Default.Register<InfoViewModel>();
            
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public BackgroundViewModel Background
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BackgroundViewModel>();
            }
        }





        /// <summary>
        /// Gets the caller.
        /// </summary>
        public CharacterViewModel Caller
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CharacterViewModel>();
            }
        }

      
        //public InfoViewModel Info => ServiceLocator.Current.GetInstance<InfoViewModel>();

        //public AbilityScoresViewModel Ability => ServiceLocator.Current.GetInstance<AbilityScoresViewModel>();

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}