using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VirusController : MonoBehaviour
{
    public float hiz;
    public static bool isReturn = true;
    public Text levelText;
    private void Start()
    {
        levelText.text = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if (isReturn)
        {
            transform.Rotate(0, 0, hiz * Time.deltaTime);
        }
    }
}
