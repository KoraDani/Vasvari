using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRenderer : MonoBehaviour
{
    public Renderer rend;
    public bool rendOn;
    public bool rendOff;
    public bool StartRend;
    public string TAG;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = StartRend;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(TAG))
        {
            rend.enabled = rendOff;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(TAG))
        {
            rend.enabled = rendOn;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TAG))
        {
            rend.enabled = rendOff;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TAG))
        {
            rend.enabled = rendOn;
        }
    }
}
