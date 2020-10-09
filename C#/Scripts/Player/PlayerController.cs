using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement playermovement;
    [SerializeField]
    private DeathChecker deathChecker = null;
    void FixedUpdate() {
        playermovement.Move(Input.GetAxisRaw("Horizontal"));
        if (Input.GetButton("Jump"))
        {
            playermovement.Jump();
        }
        deathChecker.isPlayerDeath();
    }
}
