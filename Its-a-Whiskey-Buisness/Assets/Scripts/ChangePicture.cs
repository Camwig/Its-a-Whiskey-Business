using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePicture : MonoBehaviour
{
    public GameObject activatingimage;
    public GameObject deactivatingimage;



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


}
