using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinrotator : MonoBehaviour
{
    public float spinx;
    public float spiny;
    public float spinz;
    void Update()
    {
        transform.Rotate(spinx, spiny, spinz);
    }
}
