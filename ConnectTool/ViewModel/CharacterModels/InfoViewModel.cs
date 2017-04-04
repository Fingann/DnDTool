using GalaSoft.MvvmLight;

namespace DnDTool.ViewModel.CharacterModels
{
    using DnDTool.Core.Model.Character;
    using DnDTool.Model.Messages;

    using GalaSoft.MvvmLight.Ioc;

    public class InfoViewModel : ViewModelBase
    {
        private Info info;

        public InfoViewModel()
        {
           
        }

        public Info Info
        {
            get
            {
                return this.info;
            }
            set
            {
                this.info = value;
                this.RaisePropertyChanged();
            }
        }
    }
}