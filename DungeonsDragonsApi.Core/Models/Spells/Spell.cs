using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models
{

    public class School
    {
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Class
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Subclass
    {
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Spell
    {
        public string _id { get; set; }
        public int index { get; set; }
        public string name { get; set; }
        public List<string> desc { get; set; }
        public List<string> higher_level { get; set; }
        public string page { get; set; }
        public string range { get; set; }
        public List<string> components { get; set; }
        public string material { get; set; }
        public string ritual { get; set; }
        public string duration { get; set; }
        public string concentration { get; set; }
        public string casting_time { get; set; }
        public int level { get; set; }
        public School school { get; set; }
        public List<Class> classes { get; set; }
        public List<Subclass> subclasses { get; set; }
        public string url { get; set; }
    }

   
}