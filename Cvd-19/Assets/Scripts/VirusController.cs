using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController : MonoBehaviour
{
    public float hiz;
    public static bool isReturn = true;

    void Update()
    {
        if (isReturn)
        {
            transform.Rotate(0, 0, hiz * Time.deltaTime);
        }
    }
}
