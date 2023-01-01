using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public float value;
    public float maxSpeed;
    public Rigidbody2D rb;

    private void Update()
    {
        if (rb.velocity.x >= maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Collector"))
        {
            Invoke("Collected", 0.05f);
        }
    }

    public void Collected()
    {
        Destroy(this.gameObject);
    }
}
