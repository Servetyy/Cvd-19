using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{

    public GameObject vaccine, virus;
    public Text vaccineText;
    public int vaccineAmount;
    float a;
    void Start()
    {
        vaccineText.text = "X " + vaccineAmount.ToString();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && vaccineAmount > 0)
        {
            vaccineAmount--;
            vaccineText.text = "X " + vaccineAmount.ToString();
            spawnVaccine();
            a = 0 + (255 / (vaccineAmount+1));
            GameObject.Find("Výrus").GetComponent<SpriteRenderer>().color = new Color32(255, ((byte)a), ((byte)a), 255);
        }
    }
    void spawnVaccine()
    {
        Instantiate(vaccine, transform.position, transform.rotation);
    }
}
