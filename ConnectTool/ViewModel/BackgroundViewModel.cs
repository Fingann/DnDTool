using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core;
using DnDTool.Core.Strategy.Update;
using DnDTool.Interface;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MaterialDesignThemes.Wpf;

namespace DnDTool.ViewModel
{
    using DnDTool.Core.Strategy.Enums;
    using DnDTool.ViewModel.Dialogs;
    using DnDTool.Views.Dialogs;

    public class BackgroundViewModel: ViewModelBase, IDisplayable, INavigationView
    {
        public string Title { get; set; } = "Background";
        public object Parameter { get; set; }

        public string SelectedTreassure { get; set; }

        public BackgroundViewModel()
        {
            AddCommand = new RelayCommand(AddTreasure);
            DeleteCommand = new RelayCommand<object>(DeleteTreasure);
            
        }

        private void DeleteTreasure(object item)
        {
            if (!string.IsNullOrWhiteSpace(item.ToString()))
            {
                CharacterManager.Instance.Update(new UpdateTressures(), new Tuple<ActionStrategy, string>(ActionStrategy.Delete, item.ToString()));
            }
        }

        private async void AddTreasure()
        {
            
            var queryView = new QueryDialogView()
                                {
                                    DataContext = new QueryDialogViewModel() { Info = "Treassure to Add:", AcceptButtonText = "Add"}
                                };
            var result = await DialogHost.Show(queryView, "Tressures");

            if (result is string && !string.IsNullOrWhiteSpace(result as string))
            {
                CharacterManager.Instance.Update(new UpdateTressures(), new Tuple<ActionStrategy,string>(ActionStrategy.Add, result as string));
            }
        }
        
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand<object> DeleteCommand { get; private set; }
    }
}
