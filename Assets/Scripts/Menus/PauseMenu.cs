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

    void Start()
    {
        pauseMenu.SetActive(false);
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
        pauseMenu.SetActive(true);

        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Settings()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        Time.timeScale = 1.0f;
    }
}
