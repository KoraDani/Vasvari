using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    PlayerDB playerDB = null;
    [SerializeField]
    private int amount = 0;
    void Start()
    {
        playerDB = (PlayerDB)FindObjectOfType(typeof(PlayerDB));   
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            int coin = playerDB.getCoinAmount();
            playerDB.setCoinAmount(coin+amount);
        }
    }
}
