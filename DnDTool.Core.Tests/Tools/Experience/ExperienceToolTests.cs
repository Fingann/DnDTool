using System;
using System.Text;
using System.Collections.Generic;
using DnDTool.Core.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Assert = NUnit.Framework.Assert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

namespace DnDToolTests
{
    using DnDTool.Core.Tools.Experience;

    

    /// <summary>
    /// Summary description for LevelToolTests
    /// </summary>
    [TestFixture]
    public class ExperienceToolTests
    {
       

  
        [Test]
        public void Level_Correct_Values_test()
        {
            var testlevel = ExperienceTool.GetLevel(28999);
            Assert.AreEqual(7,testlevel);
            var testLevel2 = ExperienceTool.GetLevel(240232);
            Assert.AreEqual(17, testLevel2);
            var testLevel3 = ExperienceTool.GetLevel(165000);
            Assert.AreEqual(15, testLevel3);
         
          
        }
        [Test]
        public void Level_to_high_Experience_test()
        {
         
            var testLevel4 = ExperienceTool.GetLevel(16500000);
            Assert.AreEqual(20, testLevel4);

        }

        [Test]
        public void Level_Wrong_Values_test()
        {
            var testlevel = ExperienceTool.GetLevel(-245);
            Assert.AreEqual(0, testlevel);
            var testLevel2 = ExperienceTool.GetLevel(new int());
            Assert.AreEqual(1, testLevel2);
        }


        [Test]
        public void ProficiencyBonus_test()
        {
            var testlevel = ExperienceTool.GetProficiencyBonus(28999);
            Assert.AreEqual(3, testlevel);
            var testLevel2 = ExperienceTool.GetProficiencyBonus(240232);
            Assert.AreEqual(6, testLevel2);
            var testLevel3 = ExperienceTool.GetProficiencyBonus(165000);
            Assert.AreEqual(5, testLevel3);
        }

        [Test]
        public void ProficiencyBonus_Wrong_Values_test()
        {
            var testlevel = ExperienceTool.GetProficiencyBonus(-245);
            Assert.AreEqual(2, testlevel);
            var testLevel2 = ExperienceTool.GetProficiencyBonus(new int());
            Assert.AreEqual(2, testLevel2);
        }

        [Test]
        public void ProficiencyBonus_To_High_Values_test()
        {
            
            var testLevel2 = ExperienceTool.GetProficiencyBonus(16500000);
            Assert.AreEqual(6, testLevel2);
        }
    }
}
