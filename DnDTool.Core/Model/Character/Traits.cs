using PropertyChanged;

namespace DnDTool.Core.Model.Character
{
    [ImplementPropertyChanged]
    public class Traits
    {
        public string PersonalTraits { get; set; } = "test";
        public string Ideals { get; set; } = "test";
        public string Bonds { get; set; } = "test";
        public string Flaws { get; set; } = "test";


    }
}
