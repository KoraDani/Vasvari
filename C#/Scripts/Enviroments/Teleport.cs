using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject obj;
    public string TAG;
    public float xPos;
    public float yPos;
    public float zPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(TAG))
        {
            obj.transform.position = new Vector3(xPos, yPos, zPos);
        }
    }
}
