namespace DnDTool.Core.Model.Character
{
    public class AbilityScore
    {
        public string Name { get; set; }
        public string  ShortName { get; set; }

        public string Url { get; set; }

        public int Score { get; set; } = 0;

        public int Bonus { get; set; } = 0;
    }
}
