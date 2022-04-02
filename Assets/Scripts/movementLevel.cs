using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementLevel : Ability
{
    [Tooltip("First index of the array is level 2, default values start at level 1")]
    public float[] speedPerLevel;

    public override void Execute(GameObject caller)
    {
        GameObject player = caller.gameObject;
        int level = caller.GetComponent<CharacterLeveling>().getLevel() - 2;
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        if (level < speedPerLevel.Length)
            playerMovement.setMovementSpeed(speedPerLevel[level]);
    }
}
