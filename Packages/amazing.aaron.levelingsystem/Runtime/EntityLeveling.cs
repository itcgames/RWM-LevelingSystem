using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityLeveling : MonoBehaviour
{
    int _level = 1;

    public void levelUp()
    {
        _level++;
    }

    public int getLevel()
    {
        return _level;
    }
}
