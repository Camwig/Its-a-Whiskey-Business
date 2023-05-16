using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    public AK.Wwise.Event Mouseclick;

    public GameObject button;

    public void OpenPanel()
    {
        Mouseclick.Post(gameObject);

        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }

    }

    public void OpenPanel2()
    {
        Mouseclick.Post(gameObject);

        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);

            button.SetActive(false);
        }

    }


    public void ClosePanel()
    {
        Panel.SetActive(false);

        button.SetActive(true);

    }

}
