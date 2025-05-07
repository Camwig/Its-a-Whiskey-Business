using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    public GameObject Panel2;

    public AK.Wwise.Event Mouseclick;

    public GameObject button;

    public GameObject button2;

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
        //Mouseclick.Post(gameObject);

        if (Panel2 != null)
        {
            bool isActive = Panel2.activeSelf;

            Panel2.SetActive(!isActive);

            button2.SetActive(false);
        }

    }


    public void ClosePanel()
    {
        Panel.SetActive(false);

        button.SetActive(true);

    }

    public void ClosePanel2()
    {
        Panel2.SetActive(false);

        button2.SetActive(true);

    }
}
