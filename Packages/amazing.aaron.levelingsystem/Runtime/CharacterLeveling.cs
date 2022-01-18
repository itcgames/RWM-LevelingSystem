using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLeveling : MonoBehaviour
{
    private float _experience;
    [SerializeField] private float _threshold;
    private int _level = 1;
    [SerializeField] private int _maxLevel = 10;


    public void addExperience(float t_experienceGained)
    {
        _experience += t_experienceGained;
        if (_experience >= _threshold)
        {
            _experience -= _threshold;
            if (_level < _maxLevel)
                _level++;
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
}
