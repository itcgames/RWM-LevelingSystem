using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public CharacterLeveling _level;
<<<<<<< HEAD
    public int _expGain = 2;
=======
>>>>>>> 03e12f5 (Task Complete: Dynamic Foreground [IN-13])

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
<<<<<<< HEAD
            _level.addExperience(_expGain);
=======
            _level.addExperience(10);
>>>>>>> 03e12f5 (Task Complete: Dynamic Foreground [IN-13])
        }
    }
}
