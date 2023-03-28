using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    //public Animator transition;

    //public float transitionTime = 0f;

   // public LevelLoader new_loader;

    //public int SceneID;

    public GameObject activatingcam;
    public GameObject deactivatingcam;

    //public GameObject activatingpause;
    //public GameObject deactivatingpause;

    //public GameObject activatingRoom;
    //public GameObject deactivatingRoom;



    public void ActivatingScene()
    { 
        //StartCoroutine(LoadLevel());
      //  activatingRoom.SetActive(true);
      //  activatingpause.SetActive(true);
        activatingcam.SetActive(true);
    }

    public void DeactivatingScene()
    {
     //   deactivatingRoom.SetActive(false);
    //    deactivatingpause.SetActive(false);
        deactivatingcam.SetActive(false);
    }


       //  activatingcam.SetActive(true);
       //  deactivatingcam.SetActive(false);

       //// activatingRoom.SetActive(true);


       // //if (activatingRoom == true)
       //// {
       //     activatingpause.SetActive(true);
       ////     deactivatingRoom.SetActive(false);
       //     deactivatingpause.SetActive(false);
       //// }
       
    

}
