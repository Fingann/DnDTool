using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Model.Character;

namespace DnDTool.Core.Strategy.Update
{
    public class UpdateTressures : UpdateStrategy
    {
        public override void Update(Character charecter)
        {
            throw new NotImplementedException();
        }

        public override void Update(Character charecter, object parameter)
        {
            Tuple<string, string> tressure = parameter as Tuple<string, string>;

            if (tressure ==null)
            {
                return;
            }
            switch (tressure.Item1)
            {
                case "Add":
                    charecter.Background.Tresures.Add(tressure.Item2);
                    break;
                case "Delete":
                    charecter.Background.Tresures.Remove(tressure.Item2);
                    break;


            }
        }
    }
}
