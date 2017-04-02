using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core.Strategy;
using DnDTool.Model.Character;

namespace DnDTool.Core
{
    public class CharacterManager
    {
        private Character character { get; set; }

        public CharacterManager(Character character)
        {
            this.character = character;
        }
        private UpdateStrategy _updateStrategy;

        public void SetUpdateStrategy(UpdateStrategy updateStrategy)
        {
            this._updateStrategy = updateStrategy;
        }
        
        public void Update()
        {
            _updateStrategy.Update(character);
        }
    }
}
