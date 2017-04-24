using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace DnDTool.Core.Model.Character
{
    [ImplementPropertyChanged]
    public class Background
    {
        public string Backstroy { get; set; }

        public string AlliesAndOrganisations { get; set; }
        public string Additional { get; set; }
        public string AditionalFeaturesAndTraits { get; set; }

        public string Age { get; set; }

        public string Hair { get; set; }
        public string Weight { get; set; }

        public string Skin { get; set; }
        public string Eyes { get; set; }
        public string Height { get; set; }
        public List<string> Tresures { get; set; }= new List<string>();
    
    }
}
