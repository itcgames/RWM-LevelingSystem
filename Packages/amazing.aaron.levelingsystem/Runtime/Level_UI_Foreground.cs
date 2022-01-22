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

    void Start()
    {
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        size.x = 0;
        GetComponent<RectTransform>().sizeDelta = size;
    }

    void Update()
    {
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        Vector2 totalSize = _parent.GetComponent<RectTransform>().sizeDelta;
        float percentage = _character.getPercentage();
        size.x = totalSize.x * percentage;
        GetComponent<RectTransform>().sizeDelta = size;

        if (_fillType == ExpFillDirection.LEFT_TO_RIGHT)
        {
            float offset = (totalSize.x - (totalSize.x * 0.95f)) / 2f;
            GetComponent<RectTransform>().localPosition = new Vector3(offset, -size.y /2,0f);
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
