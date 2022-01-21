using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_UI_Foreground : MonoBehaviour
{
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
    }
}
