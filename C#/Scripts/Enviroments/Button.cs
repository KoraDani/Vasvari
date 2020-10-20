using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject obj;
    public string TAG;
    [SerializeField]
    private PlayerDB playerDB = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(TAG)  && playerDB.getCoinAmount() >= 5)
        {
            Destroy(obj);
        }
        
    }
}
