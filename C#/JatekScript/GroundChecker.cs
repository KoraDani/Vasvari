using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField]
    private PlayerDB playerDB;
    void OnCollisionStay2D(Collision2D collision) {
        playerDB.setisGround(true);
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        playerDB.setisGround(false);
    }
}
