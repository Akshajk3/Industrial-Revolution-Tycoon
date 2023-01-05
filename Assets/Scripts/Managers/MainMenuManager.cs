using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Factory", LoadSceneMode.Single);
    }

    public void OpenCreadits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}
