using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLeveling : MonoBehaviour
{
    int _level;
    int _experience;
    [SerializeField] int _levelThreshold;
    [SerializeField] float _levelScaler;
    [SerializeField] int _MAX_LEVEL = 100;

    // Start is called before the first frame update
    void Start()
    {
        _level = 1;
        _experience = 0;
    }

    public void GainExperience(int t_experience)
    {
        _experience += t_experience;
        if (_experience > _levelThreshold)
        {
            ++_level;
            _experience -= _levelThreshold;
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
