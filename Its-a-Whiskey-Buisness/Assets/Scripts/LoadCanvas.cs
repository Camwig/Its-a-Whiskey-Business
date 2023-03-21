using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCanvas : MonoBehaviour
{
    public GameObject activatingRoom;
    public GameObject deactivatingRoom;


    public void MoveToScene()
    {
        activatingRoom.SetActive(true);
        deactivatingRoom.SetActive(false);
    }

}
