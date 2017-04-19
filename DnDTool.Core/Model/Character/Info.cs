namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using DnDTool.Core.Annotations;
    using DnDTool.Core.Tools;

    using PropertyChanged;

    [ImplementPropertyChanged]
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

               return ExperienceTool.GetLevel(this.experiancePoints); 
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

        

        //public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        //protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //protected bool SetField<T>(ref T field, T value, string propertyName)
        //{
        //    if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        //    field = value;
        //    OnPropertyChanged(propertyName);
        //    return true; 
        //}
    }
}