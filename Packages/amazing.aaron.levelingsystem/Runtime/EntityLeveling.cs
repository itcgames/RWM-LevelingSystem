using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityLeveling : MonoBehaviour
{
    int _level = 1;
    [SerializeField] int _maxLevel = 10;

    public void levelUp()
    {
        if (_level < _maxLevel)
        {
            _level++;
        }
    }

    public void setMaxLevel(int t_maxLevel)
    {
        _maxLevel = t_maxLevel;
    }

    public int getLevel()
    {
        return _level;
    }
}
