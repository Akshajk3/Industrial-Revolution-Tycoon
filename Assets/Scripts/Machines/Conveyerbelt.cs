using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyerbelt : MonoBehaviour
{
    public Vector2 conveyerSpeed;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(conveyerSpeed, ForceMode2D.Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody2D>();
    }
}
