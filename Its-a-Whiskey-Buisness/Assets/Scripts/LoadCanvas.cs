using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCanvas : MonoBehaviour
{
    public float transitionTime = 0f;

    public GameObject activatingpause;
    public GameObject deactivatingpause;

    public GameObject activatingRoom;
    public GameObject deactivatingRoom;



    public void MoveToScene()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(transitionTime);

        activatingRoom.SetActive(true);

        if (activatingRoom == true)
        {
            activatingpause.SetActive(true);
            deactivatingRoom.SetActive(false);
            deactivatingpause.SetActive(false);
        }

    }

}
