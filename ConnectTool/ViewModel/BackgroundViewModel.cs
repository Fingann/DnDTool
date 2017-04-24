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
    public class BackgroundViewModel: ViewModelBase, IDisplayable, INavigationView
    {
        public string Title { get; set; } = "Background";
        public object Parameter { get; set; }

        public BackgroundViewModel()
        {
            AddCommand = new RelayCommand(AddTreasure);
            DeleteCommand = new RelayCommand(DeleteTreasure);
            DialogClosingCommand= new RelayCommand<DialogClosingEventArgs>(DialogClosing);
        }

        private void DialogClosing(DialogClosingEventArgs obj)
        {
            var o =
            obj;
        }

      
       

        private void DeleteTreasure()
        {
            CharacterManager.Instance.Update(new UpdateTressures());
        }

        private void AddTreasure()
        {
            throw new NotImplementedException();
        }
        public RelayCommand<DialogClosingEventArgs> DialogClosingCommand { get; private set; }

        public RelayCommand AddCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }
    }
}
