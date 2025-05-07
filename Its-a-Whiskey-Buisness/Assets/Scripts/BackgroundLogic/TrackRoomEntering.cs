using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cameron Wiggan
public class TrackRoomEntering : MonoBehaviour
{
    [SerializeField]
    public EnergyTracker energyTrack;
    public EnergyTracker energyTrack3;


    public int SceneID;
   public void TrackActiveRooms()
    {
        if(energyTrack3.MyRoomNum != SceneID)
        {
            energyTrack3.My_ActiveOnEntryAndExit = true;
        }

        if (energyTrack.MyRoomNum != SceneID)
        {
            energyTrack.My_ActiveOnEntryAndExit = true;
        }
    }
}
