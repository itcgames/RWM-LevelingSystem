using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_UI_Foreground : MonoBehaviour
{
    public GameObject _parent;

    void Start()
    {
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        size.x = 0;
        GetComponent<RectTransform>().sizeDelta = size;
    }

}
