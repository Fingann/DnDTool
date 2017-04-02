using DnDTool.Model.Character;
using GalaSoft.MvvmLight;

namespace DnDTool.ViewModel.CharacterModels
{
    public class InfoViewModel : ViewModelBase
    {
        public InfoViewModel()
        {
            
        }
        public InfoViewModel(Info info)
        {
            Info = info;
        }

        private Info _info;

        public Info Info
        {
            get { return _info; }
            set
            {
                _info = value;
                RaisePropertyChanged();
            }
        }
    }
}
