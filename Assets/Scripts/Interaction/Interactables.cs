using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactables : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactionKey = KeyCode.E;
    public UnityEvent interactionEvent;
    public LayerMask playerLayer;
    public SpriteRenderer GFX;

    void Update()
    {
        if(inRange)
        {
            if(Input.GetKeyUp(interactionKey))
            {
                interactionEvent.Invoke();
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inRange = true;
            GFX.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inRange = false;
            GFX.color = Color.white;
        }
    }
}
