using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    LANDSCAPE,
    HORIZONTAL
}

public class UI_Direction : MonoBehaviour
{
    public Direction _direction;


    void OnValidate()
    {
        if (_direction == Direction.LANDSCAPE)
        {
            this.transform.localEulerAngles = new Vector3(0,0,0);
        }
        else
        {
            this.transform.localEulerAngles = new Vector3(0,0,-90); 
        }
    }
}
