using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EntityLevelingTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EntityLevelIncrease()
        {
            EntityLeveling e = new EntityLeveling();
            e.levelUp();
            yield return null;
            Assert.AreNotEqual(1, e.getLevel());
        }

        [UnityTest]
        public IEnumerator MaxLevelCheck()
        {
            EntityLeveling e = new EntityLeveling();
            e.setMaxLevel(1); // set max Level to 1
            e.levelUp(); // try level up
            yield return null;
            Assert.AreEqual(1, e.getLevel()); // make sure i didnt exceed the max level
        }
    }
}
