using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathChecker : MonoBehaviour
{
    [SerializeField]
    private PlayerDB playerDB = null;
    public void isPlayerDeath()
    {
        if (playerDB.getHealth() < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
