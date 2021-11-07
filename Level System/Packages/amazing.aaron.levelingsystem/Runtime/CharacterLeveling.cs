using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLeveling : MonoBehaviour
{
    int _level = 1;
    int _experience = 0;
    [SerializeField] int _levelThreshold = 100;
    [SerializeField] float _levelScaler;
    [SerializeField] int _MAX_LEVEL = 100;

    private void Start()
    {
        _levelScaler = 0.5f;
    }

    public void GainExperience(int t_experience)
    {
        _experience += t_experience;
        if (_experience >= _levelThreshold)
        {
            ++_level;
            _experience -= _levelThreshold;
            _levelThreshold = _levelThreshold + (int)(_levelThreshold * _levelScaler);
        }
    }

    public void SetThreshold(int t_threshold)
    {
        _levelThreshold = t_threshold;
    }

    public int getLevel()
    {
        return _level;
    }

    public int getThreshold()
    {
        return _levelThreshold;
    }
}
