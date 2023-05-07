using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePicture : MonoBehaviour
{
    public GameObject activatingimage;
    public GameObject deactivatingimage;
    public GameObject activateStart;

    public AK.Wwise.Event PageTurn;

    public void MoveToScene()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(0);

        activatingimage.SetActive(true);
        deactivatingimage.SetActive(true);

    }


    public void ActivatingScene()
    {

        activatingimage.SetActive(true);
    }

    public void DeactivatingScene()
    {
        deactivatingimage.SetActive(false);
    }

    public void ActivateButton()
    {
        activateStart.SetActive(true);
        PageTurn.Post(gameObject);
    }
}
