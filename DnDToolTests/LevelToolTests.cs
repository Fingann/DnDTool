using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using DnDTool.Core.Levling;
using Assert = NUnit.Framework.Assert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

namespace DnDToolTests
{
    /// <summary>
    /// Summary description for LevelToolTests
    /// </summary>
    [TestFixture]
    public class LevelToolTests
    {
       

  
        [Test]
        public void Level_test()
        {
            var testlevel = LevelTool.GetLevel(28999);
            Assert.AreEqual(7,testlevel);
            var testLevel2 = LevelTool.GetLevel(240232);
            Assert.AreEqual(17, testLevel2);
            var testLevel3 = LevelTool.GetLevel(165000);
            Assert.AreEqual(15, testLevel3);
        }

        [Test]
        public void Level_Wrong_Values_test()
        {
            var testlevel = LevelTool.GetLevel(-245);
            Assert.AreEqual(0, testlevel);
            var testLevel2 = LevelTool.GetLevel(new int());
            Assert.AreEqual(0, testLevel2);
        }


        [Test]
        public void ProficiencyBonus_test()
        {
            var testlevel = LevelTool.GetProficiencyBonus(28999);
            Assert.AreEqual(3, testlevel);
            var testLevel2 = LevelTool.GetProficiencyBonus(240232);
            Assert.AreEqual(6, testLevel2);
            var testLevel3 = LevelTool.GetProficiencyBonus(165000);
            Assert.AreEqual(5, testLevel3);
        }

        [Test]
        public void ProficiencyBonus_Wrong_Values_test()
        {
            var testlevel = LevelTool.GetLevel(-245);
            Assert.AreEqual(0, testlevel);
            var testLevel2 = LevelTool.GetLevel(new int());
            Assert.AreEqual(0, testLevel2);
        }
    }
}
