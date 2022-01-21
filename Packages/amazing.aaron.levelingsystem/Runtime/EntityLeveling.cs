using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityLeveling : MonoBehaviour
{
    int _level = 1;
    [SerializeField] int _maxLevel = 10;
    [SerializeField] Abilities[] _levelAbilities;

    public void levelUp()
    {
        if (_level < _maxLevel)
        {
            _level++;
            if (_levelAbilities != null)
            foreach (var pair in _levelAbilities)
                if (pair._boundLevel == _level)
                    pair._ability.Execute(gameObject);
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
