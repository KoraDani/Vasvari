using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDB : MonoBehaviour
{
    [SerializeField]
    private float health = 1f;
    [SerializeField]
    private float damage = 0.5f;
    private PlayerDB playerDB = null;
    private void Start()
    {
        playerDB = (PlayerDB)FindObjectOfType(typeof(PlayerDB));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerDB.setHealth(playerDB.getHealth()-damage);
        }
    }
    public void SetEnemyHealth(float health)
    {
        this.health = health;
    }
    public float getEenemyHealth()
    {
        return health;
    }
}
