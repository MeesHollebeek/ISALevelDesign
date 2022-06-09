using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Wereld");
    }

}
