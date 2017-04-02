using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Levling;
using DnDTool.Model.Character;

namespace DnDTool.Core.Strategy.Update
{
    public class LevelUpdate: UpdateStrategy
    {
        public override void Update(Character charecter)
        {
            charecter.Info.Level = LevelTool.GetLevel(charecter.Info.ExperiancePoints);
        }
    }
}
