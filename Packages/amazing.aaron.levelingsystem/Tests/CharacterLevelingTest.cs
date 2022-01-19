using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CharacterLevelingTest
    {
        [UnityTest]
        public IEnumerator GainExperience()
        {
            CharacterLeveling c = new CharacterLeveling();
            c.addExperience(100);
            yield return null;
            Assert.Greater(c.getExperience(), 0);
        }


        [UnityTest]
        public IEnumerator thresholdDrop()
        {
            CharacterLeveling c = new CharacterLeveling();
            int experienceNeeded = 50;
            c.setThreshold(experienceNeeded);
            c.addExperience(experienceNeeded + 1);
            yield return null;  
            Assert.AreEqual(1, c.getExperience());
        }

        [UnityTest]
        public IEnumerator levelIncrease()
        {
            CharacterLeveling c = new CharacterLeveling();
            int experienceNeeded = 50;
            c.setThreshold(experienceNeeded);
            c.addExperience(experienceNeeded + 1);
            yield return null;
            Assert.AreEqual(2, c.getLevel());
        }

        [UnityTest]
        public IEnumerator maxLevel()
        {
            CharacterLeveling c = new CharacterLeveling();
            int experienceNeeded = 50;
            c.setThreshold(experienceNeeded);
            c.setMaxLevel(1);
            c.addExperience(experienceNeeded + 1);
            yield return null;
            Assert.AreEqual(1, c.getLevel());
        }
    }
}
