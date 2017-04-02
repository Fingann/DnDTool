using System;
using System.Security.Cryptography.X509Certificates;
using DungeonsDragonsApi.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DungeonsDragonsApiTests
{

    using NUnit.Framework;

    [TestFixture]
    public class DungeonsDragonsApiTests
    {
        [Test]
        public void SpellsClientTest()
        {
            SpellsClient client = new SpellsClient();

            //All Spells
            var allSpells = client.GetSpellNameAll();
            Assert.IsNotNull(allSpells);
            Assert.Greater(allSpells.count,5);

            //One spell
            var spell = client.GetSpell(allSpells.results[3].Url);

            Assert.IsNotNull(spell);
            Assert.AreEqual("Alarm", spell.name);
        }

        [Test]
        public void AbilityScoreClientTest()
        {
            AbilityScoreClient client = new AbilityScoreClient();

            //All Abilitys
            var allAbilitys = client.GetSpellNameAll();
            Assert.AreEqual(6, allAbilitys.count);
            Assert.IsNotEmpty(allAbilitys.results);
            Assert.IsNotNull(allAbilitys);
            Assert.IsTrue(allAbilitys.results[0].Name == "STR");

            //One Ability
            var strength = client.Get(allAbilitys.results[0].Url);
            Assert.IsNotNull(strength.skills.Find(x => x.name == "Athletics"));
            Assert.AreEqual(strength.name, "STR");
            

        }
    }
}
