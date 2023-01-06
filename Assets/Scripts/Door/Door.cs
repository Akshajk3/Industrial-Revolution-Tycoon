using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public PlayerMovement player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You are in the next room");
            NextRoom();
        }
    }

    void NextRoom()
    {
        player.SavePlayer();
        if(SceneManager.GetActiveScene().name == "Cloth Room")
        {
            SceneManager.LoadScene("Sewing Room");
        }
        else if(SceneManager.GetActiveScene().name == "Sewing Room")
        {
            SceneManager.LoadScene("Cloth Room");
        }
    }
}
