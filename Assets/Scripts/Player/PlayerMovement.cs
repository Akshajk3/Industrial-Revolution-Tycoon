using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Animator anim;
    public float scale = 7;

    private Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement != new Vector2(0, 0))
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }

        if(movement.x < 0)
        {
            transform.localScale = new Vector3(-scale, transform.localScale.y, transform.localScale.z);
        }
        else if(movement.x > 0)
        {
            transform.localScale = new Vector3(scale, transform.localScale.y, transform.localScale.z);
        }

    }

    void FixedUpdate()
    {
        movement = movement.normalized;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector2 position;

        position.x = data.position[0];
        position.y = data.position[1];

        transform.position = position;
    }
}
