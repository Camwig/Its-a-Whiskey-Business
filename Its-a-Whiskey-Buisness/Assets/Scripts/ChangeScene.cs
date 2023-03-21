using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    //public Animator transition;

    public float transitionTime = 0f;

   // public LevelLoader new_loader;

    //public int SceneID;

    public GameObject activatingcam;
    public GameObject deactivatingcam;

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
       // transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        activatingcam.SetActive(true);
        deactivatingcam.SetActive(false);

        activatingpause.SetActive(true);
        deactivatingpause.SetActive(false);

        activatingRoom.SetActive(true);
        deactivatingRoom.SetActive(false);
    }

}
