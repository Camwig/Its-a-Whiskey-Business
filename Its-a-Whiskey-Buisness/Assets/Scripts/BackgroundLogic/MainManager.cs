using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    //The new amount of energy that should be set to the energy tracker
    private float NewEnergy;

    //Event system to check if the room has been activated
    [SerializeField]
    public EventSytem CheckActivation;

    //Event system tosignal that the energy needs to be initialised
    [SerializeField]
    public EventSytem SetupEnergy;

    //energy tracker for the appropriate room
    [SerializeField]
    private EnergyTracker energyTrack;

    //Room number that corresoonds to room this object is in
    [SerializeField]
    public int RoomNum;

    //Function to add the new energy value to the energy tracker
    public void Addenergy(Component sender, object data)
    {
        if (RoomNum == sender.GetComponent<GenericRoom>().RoomNum || sender.GetComponent<GenericRoom>().RoomNum == 0)
        {
            if (data is float)
            {
                NewEnergy = (float)data;
                energyTrack.EnergyProperty = NewEnergy;
            }
        }
    }

    //Function to set the room status (On or Off)
    public void SetRoomOn(Component sender, object data)
    {
        if (RoomNum == sender.GetComponent<GenericRoom>().RoomNum)
        {
            if (data is bool)
            {
                energyTrack.ActivatedProperty = (bool)data;
            }
        }
    }

    //Function to set the rate of energy increase in the corresponding room 
    public void SetRoomIncriment(Component sender, object data)
    {
        if (RoomNum == sender.GetComponent<GenericRoom>().RoomNum)
        {
            if (data is int)
            {
                energyTrack.IncreaseProperty = (int)data;
            }
        }
    }

    //Function to simply return the new amount of energy in the room
    public float ReturnEnergy()
    {
        return NewEnergy;
    }

    public void SetTemperature(Component sender, object data)
    {
        if (RoomNum == sender.GetComponent<GenericRoom>().RoomNum)
        {
            if (data is float)
            {
                energyTrack.MyTemperature = (float)data;
            }
        }
    }
}
