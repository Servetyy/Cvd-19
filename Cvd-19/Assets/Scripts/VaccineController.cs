using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineController : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isMoving;
    public GameObject blood;
    void Start()
    {
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
        }
        if (collision.gameObject.tag == "Vaccine")
        {

        }
    }
}
