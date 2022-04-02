using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TextStyle
{
    PERCENTAGE,
    EXPERIENCE,
    NONE
}

public class Level_UI_Text : MonoBehaviour
{

    public CharacterLeveling _character;
    public TextStyle _style;

    void Update()
    {
        if (_style == TextStyle.NONE)
            GetComponent<Text>().text = "";
        else if (_style == TextStyle.PERCENTAGE)
        {
            string text = ((int)(_character.getPercentage() * 100f)).ToString();
            text += "%";
            GetComponent<Text>().text = text;
        }
        else
        {
            string text = ((int)_character.getExperience()).ToString();
            GetComponent<Text>().text = text;
        }
    }

    void OnValidate()
    {
        if (_style == TextStyle.NONE)
            GetComponent<Text>().text = "";
        else if (_style == TextStyle.PERCENTAGE)
        {
            string text = "25%";
            GetComponent<Text>().text = text;
        }
        else
        {
            string text = "0";
            GetComponent<Text>().text = text;
        }
    }
}
