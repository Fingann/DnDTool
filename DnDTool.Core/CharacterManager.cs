// ReSharper disable StyleCop.SA1600
namespace DnDTool.Core
{
    using System.Diagnostics.CodeAnalysis;

    using DnDTool.Core.Model.Character;
    using DnDTool.Core.Strategy;

    public sealed class CharacterManager
    {
        private static CharacterManager instance;

        private UpdateStrategy updateStrategy;

        private CharacterManager()
        {
        }

        public static CharacterManager Instance => instance ?? (instance = new CharacterManager());

        public Character Character { get; set; }

        public void SetUpdateStrategy(UpdateStrategy updateStrat)
        {
            this.updateStrategy = updateStrat;
        }

        public void Update()
        {
            if (this.Character != null)
            {
                this.updateStrategy.Update(this.Character);
            }
        }

        public void Update(UpdateStrategy updateStrat)
        {
            this.updateStrategy = updateStrat;
            if (this.Character != null)
            {
                this.updateStrategy.Update(this.Character);
            }
        }
    }
}