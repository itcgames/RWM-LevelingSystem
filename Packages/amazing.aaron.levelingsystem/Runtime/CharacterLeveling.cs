using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Abilities
{
    public int _boundLevel;
    public Ability _ability;
}

public class CharacterLeveling : MonoBehaviour
{
    private float _experience;
    [SerializeField] private float _threshold = 100;
    private int _level = 1;
    [SerializeField] private int _maxLevel = 10;
    [SerializeField] Abilities[] _levelAbilities;

    public void addExperience(float t_experienceGained)
    {
        _experience += t_experienceGained;
        if (_experience >= _threshold)
        {
            _experience -= _threshold;
            if (_level < _maxLevel)
            {
                setThreshold(_threshold + 10 * _level);
                _level++;

                foreach (Abilities ability in _levelAbilities)
                    if (ability._boundLevel == _level)
                        ability._ability.Execute(gameObject);
            }
        }
    }

    public void setMaxLevel(int t_maxLevel)
    {
        _maxLevel = t_maxLevel;
    }

    public void setThreshold(float t_threshold)
    {
        _threshold = t_threshold;
    }

    public int getLevel()
    {
        return _level;
    }

    public float getExperience()
    {
        return _experience;
    }

    public float getThreshold()
    {
        return _threshold;
    }

    public float getPercentage()
    {
        return _experience / _threshold;
    }
}
