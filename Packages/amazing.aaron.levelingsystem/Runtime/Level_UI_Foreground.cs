using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ExpFillDirection
{
    LEFT_TO_RIGHT,
    RIGHT_TO_LEFT,
    CENTER_FILL
}

public class Level_UI_Foreground : MonoBehaviour
{
    public ExpFillDirection _fillType;
    public GameObject _parent;
    public CharacterLeveling _character;


    float _targetWidth;
    [SerializeField] float _barGrowthRate;

    void Start()
    {
        _targetWidth = 0;
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        size.x = 0;
        GetComponent<RectTransform>().sizeDelta = size;
    }

    void Update()
    {
        updatePos();

        Vector2 currSize = GetComponent <RectTransform>().sizeDelta;
        if (currSize.x < _targetWidth)
            currSize.x += _barGrowthRate;
        else if (currSize.x > _targetWidth)
            currSize.x -= _barGrowthRate;

        if (currSize.x > _targetWidth)
            currSize.x = _targetWidth;

        GetComponent<RectTransform>().sizeDelta = currSize;
    }

    void OnValidate()
    {
        updatePos();
    }

    private void updatePos()
    {
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        Vector2 totalSize = _parent.GetComponent<RectTransform>().sizeDelta;

        if (_character)
        {
            float percentage = _character.getPercentage();
            _targetWidth = totalSize.x * percentage;          
        }

        if (_fillType == ExpFillDirection.LEFT_TO_RIGHT)
        {
            float offset = (totalSize.x - (totalSize.x * 0.95f)) / 2f;
            GetComponent<RectTransform>().localPosition = new Vector3(offset, -size.y / 2, 0f);
        }
        else if (_fillType == ExpFillDirection.RIGHT_TO_LEFT)
        {
            float border = (totalSize.x - (totalSize.x * 0.95f)) / 2f;
            float pos = totalSize.x - border;
            pos -= (size.x * 0.9f);
            GetComponent<RectTransform>().localPosition = new Vector3(pos, -size.y / 2, 0f);
        }
        else if (_fillType == ExpFillDirection.CENTER_FILL)
        {
            float border = (totalSize.x - (totalSize.x * 0.95f)) / 2f;
            float offset = totalSize.x / 2f;
            offset -= size.x / 2f;
            offset += border * 2f;
            GetComponent<RectTransform>().localPosition = new Vector3(offset, -size.y / 2, 0f);
        }
    }
}
