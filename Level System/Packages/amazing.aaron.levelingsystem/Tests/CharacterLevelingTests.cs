﻿using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CharacterLevelingTests
{

    private CharacterLeveling leveling;

    [SetUp]
    public void Setup()
    {
        GameObject gameGameObject =
          MonoBehaviour.Instantiate(
            Resources.Load<GameObject>("Prefabs/Game"));
        GameObject player = gameGameObject.transform.Find("Player").gameObject;
        if (player != null)
            leveling = player.GetComponent<CharacterLeveling>();
    }

    [TearDown]
    public void Teardown()
    {
    }

    [UnityTest]
    public IEnumerator ExperiencePoints()
    {
        if (leveling != null)
        {
            Assert.True(1 == leveling.getLevel());
            leveling.SetThreshold(100); 
            leveling.GainExperience(101);
            yield return new WaitForEndOfFrame();
            Assert.Greater(leveling.getLevel(), 1);
        }
        yield return null;
    }

    [UnityTest]
    public IEnumerator ThresholdTest()
    {
        if (leveling != null)
        {
            leveling.SetThreshold(50);
            yield return new WaitForEndOfFrame();
            Assert.AreEqual(50, leveling.getThreshold());
        }
        yield return null;
    }
}