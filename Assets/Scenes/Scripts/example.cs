using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : Ability
{
    public override void Execute(GameObject t_caller)
    {
        Debug.Log("I am an ability");
    }
}
