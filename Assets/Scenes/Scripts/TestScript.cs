using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public CharacterLeveling _level;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _level.addExperience(10);
        }
    }
}
