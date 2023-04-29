using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int SceneID;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneID);
    }

    public void Settings()
    {
        SceneManager.LoadScene(SceneID);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(SceneID);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
