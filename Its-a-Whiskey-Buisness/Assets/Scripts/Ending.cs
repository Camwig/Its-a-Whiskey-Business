using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public GameObject panel;

    public float winner;

    public void OnButtonClick()
    {
        panel.SetActive(panel);
    }
}
