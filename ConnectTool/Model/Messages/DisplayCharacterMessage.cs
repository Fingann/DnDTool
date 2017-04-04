using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Model.Messages
{
    using DnDTool.Core.Model.Character;

    public class DisplayCharacterMessage
    {
        public DisplayCharacterMessage(ref Character character)
        {
            Character = character;
        }
        public Character Character { get; set; }
    }
}
