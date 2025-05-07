using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cameron Wiggan

public class GenericRoomManager : MonoBehaviour
{
    //Holds the correct generic room object
    public GenericRoom this_room;

    //The energy tracker assigned to this room
    [SerializeField]
    public EnergyTracker energyTracker;

    //Holds a refrence to the gameobject that holds this script
    [SerializeField]
    public GameObject this_manager;

    //Holds a value to determine if the room was active upon entry and exit
    private int check_on_exit = 0;

    //Holds the room number associated with the room this object is attached to
    public int Roomnum;

    public void RunSetup()
    {
        //Set the room number to be the same room number as the attached generic room
        Roomnum = this_room.RoomNum;

        //Checks if this is the first time this is being run
        if (energyTracker.My_firstPlay == true)
        {
            //Run the appropriate code
            energyTracker.My_firstPlay = false;
            this_room.first_run = true;
            this_room.SetupState();
        }
        else
        {

            //Checks if this room is active upon re-entry
            if (energyTracker.ActivatedProperty == true)
            {
                check_on_exit = 1;
            }
            else
            {
                check_on_exit = 0;
            }

            this_room.SetupInitialEnergy(this_manager.GetComponent<GenericRoomManager>(), energyTracker.EnergyProperty);

            this_room.ActivateRoom_Manager(this_manager.GetComponent<GenericRoomManager>(), energyTracker.ActivatedProperty);

            this_room.SetupInitialTemperature(this_manager.GetComponent<GenericRoomManager>(), energyTracker.MyTemperature);
        }
    }

    public void OnClose()
    {
        //IF the room was active upon re-entry
        if (check_on_exit == 1)
        {
            //Set the appropriate values
            energyTracker.My_ActiveOnEntryAndExit = true;
            check_on_exit = 0;
        }
    }

}