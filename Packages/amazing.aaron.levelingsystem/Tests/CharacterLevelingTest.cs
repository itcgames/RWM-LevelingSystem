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
            c.setThreshold(50);
            c.addExperience(100);
            yield return null;  
            Assert.AreEqual(50, c.getExperience());
        }
    }
}
