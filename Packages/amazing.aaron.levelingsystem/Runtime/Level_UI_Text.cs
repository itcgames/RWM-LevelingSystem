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
    

    // Update is called once per frame
    void Update()
    {
        if (_style == TextStyle.NONE)
            gameObject.SetActive(false);    
        else if (_style == TextStyle.PERCENTAGE)
        {
            string text = (_character.getPercentage() * 100.0f).ToString();
            text += '%';
            GetComponent<Text>().text = text;
        }
        else
        {
            string text = _character.getExperience().ToString();
            GetComponent<Text>().text = text;
        }
    }
}
