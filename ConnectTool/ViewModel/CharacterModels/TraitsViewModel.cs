using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Model.Character;
using GalaSoft.MvvmLight;

namespace DnDTool.ViewModel.CharacterModels
{
    public class TraitsViewModel: ViewModelBase
    {
        private Traits _traits;

        public Traits Traits
        {
            get { return _traits; }
            set
            {
                _traits = value;
                RaisePropertyChanged();
            }
        }

        public TraitsViewModel(Traits traits)
        {
            this.Traits = traits;
        }

        public TraitsViewModel()
        {
            
        }
    }
}
