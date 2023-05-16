using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener2 : MonoBehaviour
{
    public GameObject Panel;

    //  public Animator Flash;


    public AK.Wwise.Event MouseClick;

    public void OpenPanel()
    {

        MouseClick.Post(gameObject);

        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }

    }


    public void ClosePanel()
    {

        MouseClick.Post(gameObject);
        Panel.SetActive(false);


    }
}
