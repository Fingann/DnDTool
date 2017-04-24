using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Tools;

namespace DnDTool.Core.Strategy.Update
{
    using DnDTool.Core.Model.Character;
    using DnDTool.Core.Tools.Experience;

    public class UpdateLevel: UpdateStrategy
    {
        public override void Update(Character charecter)
        {
            charecter.Info.Level = ExperienceTool.GetLevel(charecter.Info.ExperiencePoints);
        }

        public override void Update(Character charecter, object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
