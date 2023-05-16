using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int SceneID;

    public AK.Wwise.Event MouseClick;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneID);
        MouseClick.Post(gameObject);
    }

    public void Settings()
    {
        SceneManager.LoadScene(SceneID);
        MouseClick.Post(gameObject);
    }

    public void QuitGame()
    {
        Application.Quit();
        MouseClick.Post(gameObject);
    }
}
