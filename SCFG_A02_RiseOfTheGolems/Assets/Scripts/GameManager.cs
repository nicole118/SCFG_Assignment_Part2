using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public int sceneNumber;
    private void Update()
    {
        PauseGame();
    }
    public void goToScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    } 

    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToLevel()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
