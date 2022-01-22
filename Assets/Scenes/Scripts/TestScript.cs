using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public CharacterLeveling _level;
    public int _expGain = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _level.addExperience(_expGain);
        }
    }
}
