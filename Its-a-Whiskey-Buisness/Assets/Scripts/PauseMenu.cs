using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    [SerializeField] Mode mody;

    [SerializeField] Button EasyButton;

    [SerializeField] Button NormalButton;

    private static bool easyOrNo;

    public GameObject MainCursor;

    public AK.Wwise.Event MouseClick;


    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        MouseClick.Post(gameObject);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        if (easyOrNo == true)
        {
            Time.timeScale = 0.5f;
        }
        else if (easyOrNo == false)
        {
            Time.timeScale = 1.0f;
        }

        MouseClick.Post(gameObject);

    }

    public void Home(int SceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneID);
        MouseClick.Post(gameObject);
    }

    public void Quit()
    {
        Application.Quit();
        MouseClick.Post(gameObject);
    }

    public void Slow()
    {
        if (EasyButton.GetComponent<Button>() == true)
        {
            easyOrNo = true;
            MouseClick.Post(gameObject);
        }
    }

    public void Normal()
    {
        if (NormalButton.GetComponent<Button>() == true)
        {
            easyOrNo = false;
            MouseClick.Post(gameObject);
        }
    }

    public void Retry()
    {

        if (easyOrNo == true)
        {
            Time.timeScale = 0.5f;
        }
        else if (easyOrNo == false)
        {
            Time.timeScale = 1.0f;
        }

        MouseClick.Post(gameObject);
    }

    public void ChangeCursor()
    {
        MainCursor.SetActive(false);
    }

    public void ResetCursor()
    {
        MainCursor.SetActive(true);
    }


}
