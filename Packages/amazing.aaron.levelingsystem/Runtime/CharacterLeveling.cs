using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLeveling : MonoBehaviour
{
    private float _experience;
    [SerializeField] private float _threshold;


    public void addExperience(float t_experienceGained)
    {
        _experience += t_experienceGained;
        if (_experience > _threshold)
            _experience -= _threshold;
    }

    public void setThreshold(float t_threshold)
    {
        _threshold = t_threshold;
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
