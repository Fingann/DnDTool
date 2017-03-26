using System.Collections.Generic;
using DnDTool.Interface;

namespace DnDTool.Model.Services
{
    public interface INavigationService
    {

        void GoBack();

        void NavigateTo(string pageKey);

        void NavigateTo(string pageKey, object parameter);
        
        

        IDisplayable CurrentView { get; set; }

        string CurrentViewIdentifier { get; }

        List<string> GetDisplayableViews();

        Dictionary<string, IDisplayable> MenuList { get; }

        void NavigateToStartPage();
    }
}
