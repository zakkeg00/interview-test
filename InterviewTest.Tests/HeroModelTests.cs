﻿using InterviewTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTest.Tests
{
    [TestClass]
    [TestCategory("Heroes")]
    public class HeroModelTests
    {
        private IHero hero = new Hero()
        {
            name = "Hulk",
            power = "Strength from gamma radiation",
            stats =
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 5000 ),
                       new KeyValuePair<string, int>( "intelligence", 50),
                       new KeyValuePair<string, int>( "stamina", 2500 )
                   }
        };

        [TestMethod]
        [TestCategory("evolve")]
        public void Evolve()
        {
            var initialStats = hero.stats;

            var strengthStat = initialStats.FirstOrDefault(x => x.Key == "strength");
            var intelligenceStat = initialStats.FirstOrDefault(x => x.Key == "intelligence");
            var staminaStat = initialStats.FirstOrDefault(x => x.Key == "stamina");

            hero.evolve();

            var evolvedStats = hero.stats;

            var evolvedStrengthStat = evolvedStats.FirstOrDefault(x => x.Key == "strength");
            var evolvedIntelligenceStat = evolvedStats.FirstOrDefault(x => x.Key == "intelligence");
            var evolevedStaminaStat = evolvedStats.FirstOrDefault(x => x.Key == "stamina");

            Assert.IsTrue(((strengthStat.Value * 0.5 * 5) + strengthStat.Value) == evolvedStrengthStat.Value);
        }

        [TestMethod]
        [TestCategory("evolve")]
        public void EvolveFactor()
        {
            int factorInt = 2;

            var initialStats = hero.stats;

            var strengthStat = initialStats.FirstOrDefault(x => x.Key == "strength");
            var intelligenceStat = initialStats.FirstOrDefault(x => x.Key == "intelligence");
            var staminaStat = initialStats.FirstOrDefault(x => x.Key == "stamina");

            hero.evolve(factorInt);

            var evolvedStats = hero.stats;

            var evolvedStrengthStat = evolvedStats.FirstOrDefault(x => x.Key == "strength");
            var evolvedIntelligenceStat = evolvedStats.FirstOrDefault(x => x.Key == "intelligence");
            var evolevedStaminaStat = evolvedStats.FirstOrDefault(x => x.Key == "stamina");

            Assert.IsTrue(((strengthStat.Value * 0.5 * factorInt) + strengthStat.Value) == evolvedStrengthStat.Value);
        }

        [TestMethod]
        [TestCategory("evolve")]
        public void EvolveFactor0()
        {
            int factorInt = 0;

            var initialStats = hero.stats;

            var strengthStat = initialStats.FirstOrDefault(x => x.Key == "strength");
            var intelligenceStat = initialStats.FirstOrDefault(x => x.Key == "intelligence");
            var staminaStat = initialStats.FirstOrDefault(x => x.Key == "stamina");

            hero.evolve(factorInt);

            var evolvedStats = hero.stats;

            var evolvedStrengthStat = evolvedStats.FirstOrDefault(x => x.Key == "strength");
            var evolvedIntelligenceStat = evolvedStats.FirstOrDefault(x => x.Key == "intelligence");
            var evolevedStaminaStat = evolvedStats.FirstOrDefault(x => x.Key == "stamina");

            Assert.IsTrue(((strengthStat.Value * 0.5 * factorInt) + strengthStat.Value) == evolvedStrengthStat.Value);
        }

        [TestMethod]
        [TestCategory("evolve")]
        public void EvolveNoStats()
        {
            hero = new Hero()
            {
                name = "Hulk",
                power = "Strength from gamma radiation",
            };

            hero.evolve();

            Assert.IsTrue(true);
        }
    }
}
