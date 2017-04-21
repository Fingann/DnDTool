using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DnDTool.Core.Tests
{
    using DnDTool.Core.Model.Character;
    using NUnit.Framework;

    [TestFixture]
    public class CharacterTests
    {
        public Character charecter { get; set; } = new Character();


        [Test]
        public void Character_Experience_Test()
        {
            CharacterManager.Instance.Character = charecter;
            Assert.AreEqual(0,charecter.Info.Level);
            Assert.AreEqual(2, charecter.AbilityScores.ProficiencyBonus);

            this.charecter.Info.ExperiencePoints = 14000;
            Assert.AreEqual(6, charecter.Info.Level);
            Assert.AreEqual(3, charecter.AbilityScores.ProficiencyBonus);
        
        }
    }
}
