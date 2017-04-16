using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Model.Character;

namespace DnDTool.ViewModel.CharacterModels
{
    public class TraitsViewModel
    {
        public Traits Traits { get; set; }

        public TraitsViewModel(Traits traits)
        {
            this.Traits = traits;
        }

        public TraitsViewModel()
        {
            
        }
    }
}
