using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int amountVaccine;
    public Text amounttext;
    string a;
    private void Start()
    {
        amountVaccine = 0;
        a = amounttext.text;
    }
    void Update()
    {
        if (a == amountVaccine.ToString())
        {
            if (SceneManager.GetActiveScene().name == "10") SceneManager.LoadScene("Levels");
            else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
