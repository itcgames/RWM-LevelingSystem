using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpLevel : Ability
{
    [Tooltip("First index of the array is level 2, default values start at level 1")]
    public float[] jumpPerLevel;

    public override void Execute(GameObject caller)
    {
        GameObject player = caller.gameObject;
        int level = caller.GetComponent<CharacterLeveling>().getLevel() - 2;
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        if (level < jumpPerLevel.Length)
            playerMovement.setJumpForce(jumpPerLevel[level]);
    }
}
