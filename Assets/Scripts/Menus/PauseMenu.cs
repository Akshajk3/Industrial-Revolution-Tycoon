using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public KeyCode pauseButton = KeyCode.Escape;
    public GameObject pauseMenu;
    public GameObject endGameMenu;
    bool gameEnded;

    void Start()
    {
        pauseMenu.SetActive(false);
        endGameMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            if (pauseMenu.activeInHierarchy)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        if (gameEnded == false)
        {
            pauseMenu.SetActive(true);

            Time.timeScale = 0.0f;
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void EndGame()
    {
        endGameMenu.SetActive(true);
        gameEnded = true;
        Time.timeScale = 0.0f;
    }

    public void Continue()
    {
        endGameMenu.SetActive(false);
        gameEnded = false;
        Time.timeScale = 1.0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        Time.timeScale = 1.0f;
    }
}
