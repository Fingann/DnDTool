using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Model.Character;

namespace DnDTool.Core.Strategy.Update
{
    using DnDTool.Core.Strategy.Enums;

    public class UpdateTressures : UpdateStrategy
    {
        public override void Update(Character charecter)
        {
            throw new NotImplementedException();
        }

        public override void Update(Character charecter, object parameter)
        {
            Tuple<ActionStrategy, string> tressure = parameter as Tuple<ActionStrategy, string>;

            if (tressure ==null)
            {
                return;
            }
            switch (tressure.Item1)
            {
                case ActionStrategy.Add:
                    charecter.Background.Tresures.Add(tressure.Item2);
                    break;
                case ActionStrategy.Delete:
                    charecter.Background.Tresures.Remove(tressure.Item2);
                    break;


            }
        }
    }
}
