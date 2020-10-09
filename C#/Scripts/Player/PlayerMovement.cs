using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D Playerbody;
    [SerializeField]
    private PlayerDB playerDB;

    public void Move(float horizontalInput) 
    {
        Vector2 moveVelocity = Playerbody.velocity;
        float move = moveVelocity.x = horizontalInput * playerDB.getSpeed();
        Playerbody.velocity = moveVelocity;
    }
    public void Jump() {
        if (playerDB.getisGround())
        {
            Playerbody.velocity = new Vector2(Playerbody.velocity.x, playerDB.getJump());
        }

    }
}
