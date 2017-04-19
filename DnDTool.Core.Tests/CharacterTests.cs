using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DnDTool.Core.Tests
{
    using DnDTool.Core.Model.Character;

    [TestClass]
    public class CharacterTests
    {
        public Character charecter { get; set; } = new Character();


        [TestMethod]
        public void Character_AbilityScore_Test()
        {
            var list = charecter.AbilityScores;
        }
    }
}
