using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void PlayGame()
    {
        SceneManager.LoadScene("Levels");
        Finish.isPaused = false;
    }
    public void QuitGame()
    {
        Application.Quit();
        Finish.isPaused = false;
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Finish.isPaused = false;
    }


}
