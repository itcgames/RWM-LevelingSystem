using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractTestImp : Ability
{
    private int _value =0;
    public override void Execute(GameObject t_caller)
    {
        t_caller.GetComponent<AbstractTestImp>()._value = 1;
    }

    public int getValue()
    {
        return _value;
    }
}
