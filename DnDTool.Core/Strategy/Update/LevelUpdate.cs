using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Tools;

namespace DnDTool.Core.Strategy.Update
{
    using DnDTool.Core.Model.Character;

    public class LevelUpdate: UpdateStrategy
    {
        public override void Update(Character charecter)
        {
            charecter.Info.Level = LevelTool.GetLevel(charecter.Info.ExperiancePoints);
        }
    }
}
