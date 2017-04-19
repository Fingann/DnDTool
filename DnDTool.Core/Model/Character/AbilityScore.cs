namespace DnDTool.Core.Model.Character
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class AbilityScore
    {
        private int bonus = 0;

        public string Name { get; set; }
        public string  ShortName { get; set; }

        public string Url { get; set; }

        public int Score { get; set; } = 0;

        

        public int Bonus
        {
            get
            {
                double calc1 = Score / 2;
                double calc2 = calc1 - 5;
                
                double bonus = (Math.Floor(calc2));
                return Convert.ToInt32(bonus);
            }
            
        }

        public BindingList<SavingThrow> SavingThrows { get; set; } 
    }
}
