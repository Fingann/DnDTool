namespace DnDTool.Core.Model.Character
{
  

    public class Info 
    {
        private string allignment;

        private string background;

        private string charecterName = "soldrak";

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
            
            }
        }
    }
}