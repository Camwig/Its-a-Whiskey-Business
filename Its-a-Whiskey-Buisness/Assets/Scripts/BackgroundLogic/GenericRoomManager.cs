using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericRoomManager : MonoBehaviour
{
    public GameObject lever;

    //--------------------------
    public GameObject slider;

    //public SliderInteractable slider;
    //--------------------------

    [SerializeField]
    public ObjectPositioing these_objects;

    public GenericRoom this_room;

    [SerializeField]
    public EnergyTracker energyTracker;

    [SerializeField]
    public EnergyTracker energyTracker2;

    [SerializeField]
    public SliderState new_slide_state;

    //private static bool firstPlay = true;

    private int check_on_exit = 0;


    void Awake()
    {
        if (energyTracker.My_firstPlay == true)
        {
            Debug.Log("Starting...\n");
            //firstPlay = false;
            energyTracker.My_firstPlay = false;
            //new_slide_state.StateProperty = false;
            this_room.SetupState();

            //int i = energyTracker.IncreaseProperty;
            //these_objects.gameObjects[0].transform.rotation = lever.transform.rotation;

            //if(energyTracker2.ActivatedProperty)
            //{
            //    int j = 0;
            //}
        }
        else
        {
            Debug.Log("Running...\n");
            //Store the angle the lever was at after exit
            lever.transform.position = these_objects.gameObjects[0].transform.position;
            lever.transform.rotation = these_objects.gameObjects[0].transform.rotation;

            //--------------------------
            //slider.transform.position = these_objects.gameObjects[1].transform.position;
            //slider.transform.rotation = these_objects.gameObjects[1].transform.rotation;
            //--------------------------

            if(energyTracker.ActivatedProperty == true)
            {
                check_on_exit = 1;
            }
            else
            {
                check_on_exit = 0;
            }

            this_room.ActivateRoom(this,energyTracker.ActivatedProperty);
            this_room.SetupInitialEnergy(this, energyTracker.EnergyProperty);
        }
    }

    //When it is destroyed it is on
    private void OnDestroy()
    {
        //if (energyTracker2.ActivatedProperty)
        //{
        //    int j = 0;
        //}

        if(check_on_exit == 1)
        {
            energyTracker.My_ActiveOnEntryAndExit = true;
            check_on_exit = 0;
        }
    }
}
