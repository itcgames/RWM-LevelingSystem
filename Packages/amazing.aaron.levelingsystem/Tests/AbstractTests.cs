using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AbstractTests
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator AbstractTestsWithEnumeratorPasses()
        {
            GameObject g = new GameObject();
            AbstractTestImp imp = g.AddComponent<AbstractTestImp>();
            Ability ab = imp;
            ab.Execute(g);
            yield return new WaitForEndOfFrame();
            Assert.AreNotEqual(0, imp.getValue());
        }
    }
}
