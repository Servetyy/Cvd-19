using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VaccineController : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isMoving;
    public GameObject blood;
    AudioSource gameSounds;
    public AudioClip hitClip, endClip;
    void Start()
    {
        gameSounds = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!isMoving)
        {
            rb.MovePosition(rb.position + Vector2.up * 40 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Výrus")
        {
            Destroy(Instantiate(blood, transform.position, transform.rotation), 1f);
            transform.SetParent(collision.transform);
            isMoving = true;
            gameSounds.PlayOneShot(hitClip);
            GameManager.amountVaccine++;
        }
        if (collision.gameObject.CompareTag("Vaccine"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.gameObject.CompareTag("levelVaccine"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
