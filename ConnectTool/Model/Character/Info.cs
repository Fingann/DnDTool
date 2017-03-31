namespace DnDTool.Model.Character
{
    using GalaSoft.MvvmLight;

    public class Info : ViewModelBase
    {
        private string allignment;

        private string background;

        private string charecterName;

        private int experiancePoints;

        private int level;

        private string playerClass;

        private string playerName;

        private string race;

        public string Allignment
        {
            get
            {
                return this.allignment;
            }

            set
            {
                this.allignment = value;
                this.RaisePropertyChanged();
            }
        }

        public string Background
        {
            get
            {
                return this.background;
            }

            set
            {
                this.background = value;
                this.RaisePropertyChanged();
            }
        }

        public string CharecterName
        {
            get
            {
                return this.charecterName;
            }

            set
            {
                this.charecterName = value;
                this.RaisePropertyChanged();
            }
        }

        public string Class
        {
            get
            {
                return this.playerClass;
            }

            set
            {
                this.playerClass = value;
                this.RaisePropertyChanged();
            }
        }

        public int ExperiancePoints
        {
            get
            {
                return this.experiancePoints;
            }

            set
            {
                this.experiancePoints = value;
                this.RaisePropertyChanged();
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }

            set
            {
                this.level = value;
                this.RaisePropertyChanged();
            }
        }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            set
            {
                this.playerName = value;
                this.RaisePropertyChanged();
            }
        }

        public string Race
        {
            get
            {
                return this.race;
            }

            set
            {
                this.race = value;
                this.RaisePropertyChanged();
            }
        }
    }
}