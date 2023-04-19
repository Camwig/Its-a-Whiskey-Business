using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingLayers : MonoBehaviour
{
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Room3;
    public GameObject Room4;
    public GameObject Email;

    public void ActivateRoom1()
    {

        Room1.SetActive(true);
        Room2.SetActive(false);
        Room3.SetActive(false);
        Room4.SetActive(false);
        Email.SetActive(false);

    }
    public void ActivateRoom2()
    {

        Room2.SetActive(true);
        Room1.SetActive(false);
        Room3.SetActive(false);
        Room4.SetActive(false);
        Email.SetActive(false);

    }
    public void ActivateRoom3()
    {

        Room3.SetActive(true);
        Room2.SetActive(false);
        Room1.SetActive(false);
        Room4.SetActive(false);
        Email.SetActive(false);

    }
    public void ActivateRoom4()
    {

        Room4.SetActive(true);
        Room2.SetActive(false);
        Room3.SetActive(false);
        Room1.SetActive(false);
        Email.SetActive(false);

    }
    public void ActivateEmail()
    {

        Email.SetActive(true);
        Room1.SetActive(false);
        Room2.SetActive(false);
        Room3.SetActive(false);
        Room4.SetActive(false);

    }

    public void Reset()
    {

        Room1.SetActive(true);
        Room2.SetActive(true);
        Room3.SetActive(true);
        Room4.SetActive(true);
        Email.SetActive(true);

    }

}
