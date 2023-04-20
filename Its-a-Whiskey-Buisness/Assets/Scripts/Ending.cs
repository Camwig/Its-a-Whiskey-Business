using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public GameObject winningpanel;
    public GameObject losingpanel;
    public GameObject mainPanel;

    public float winner;

    public void OnButtonClick()
    {
        losingpanel.SetActive(losingpanel);
    }

    public void Resume()
    {
        winningpanel.SetActive(false);
        losingpanel.SetActive(false);
    }

    public void Return()
    {
        mainPanel.SetActive(false);

    }
}
