using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject activatingcam;
    public GameObject deactivatingcam;



    public void ActivatingScene()
    { 

        activatingcam.SetActive(true);
    }

    public void DeactivatingScene()
    {
        deactivatingcam.SetActive(false);
    }
     
    

}
