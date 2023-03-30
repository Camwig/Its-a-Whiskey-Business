//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GenericRoomManager : MonoBehaviour
//{
//    //Holds the refrences to certain game objects.
//    public GameObject lever;
//    public GameObject slider;
//    public GenericRoom this_room;

//    //Refences the objects in the scene
//    [SerializeField]
//    public ObjectPositioing these_objects;
//    [SerializeField]
//    public EnergyTracker energyTracker;
//    [SerializeField]
//    public EnergyTracker energyTracker2;
//    [SerializeField]
//    public SliderState new_slide_state;

//    private int check_on_exit = 0;

//    //Runs when the object is first activated within the scene
//    void Awake()
//    {
//        //On the first activation runs the following code and functions
//        if (energyTracker.My_firstPlay == true)
//        {
//            Debug.Log("Starting...\n");
//            //firstPlay = false;
//            energyTracker.My_firstPlay = false;
//            //new_slide_state.StateProperty = false;
//            this_room.SetupState();
//        }
//        else
//        {
//            Debug.Log("Running...\n");
//            //Store the angle the lever was at after exit

//            //Not super needed at the momenmt but I shall keep it in as its not that harmful at the moment
//            lever.transform.position = these_objects.gameObjects[0].transform.position;
//            lever.transform.rotation = these_objects.gameObjects[0].transform.rotation;

//            //--------------------------
//            //slider.transform.position = these_objects.gameObjects[1].transform.position;
//            //slider.transform.rotation = these_objects.gameObjects[1].transform.rotation;
//            //--------------------------

//            //Checks if this room is active upon re-entry
//            if(energyTracker.ActivatedProperty == true)
//            {
//                check_on_exit = 1;
//            }
//            else
//            {
//                check_on_exit = 0;
//            }

//            //Sets up the initial values for the room
//            this_room.ActivateRoom(this,energyTracker.ActivatedProperty);
//            this_room.SetupInitialEnergy(this, energyTracker.EnergyProperty);
//        }
//    }

//    //When it is destroyed it is on
//    private void OnDestroy()
//    {
//        //If the room is active upon re-entry when it goes to destroy itself it will set a value to say if it has remained on throughout its time within the room
//        //This helps with totalling the energy within the overhead
//        if(check_on_exit == 1)
//        {
//            energyTracker.My_ActiveOnEntryAndExit = true;
//            check_on_exit = 0;
//        }
//    }

//    public void RunSetup()
//    {
//        if (energyTracker.My_firstPlay == true)
//        {
//            Debug.Log("Starting...\n");
//            //firstPlay = false;
//            energyTracker.My_firstPlay = false;
//            //new_slide_state.StateProperty = false;
//            this_room.SetupState();
//        }
//        else
//        {
//            Debug.Log("Running...\n");
//            //Store the angle the lever was at after exit

//            //Not super needed at the momenmt but I shall keep it in as its not that harmful at the moment
//            lever.transform.position = these_objects.gameObjects[0].transform.position;
//            lever.transform.rotation = these_objects.gameObjects[0].transform.rotation;

//            //--------------------------
//            //slider.transform.position = these_objects.gameObjects[1].transform.position;
//            //slider.transform.rotation = these_objects.gameObjects[1].transform.rotation;
//            //--------------------------

//            //Checks if this room is active upon re-entry
//            if (energyTracker.ActivatedProperty == true)
//            {
//                check_on_exit = 1;
//            }
//            else
//            {
//                check_on_exit = 0;
//            }

//            //Sets up the initial values for the room
//            this_room.ActivateRoom(this, energyTracker.ActivatedProperty);
//            this_room.SetupInitialEnergy(this, energyTracker.EnergyProperty);
//        }
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericRoomManager : MonoBehaviour
{
    //Holds the refrences to certain game objects.
    public GameObject lever;
    public GameObject slider;
    public GenericRoom this_room;

    //Refences the objects in the scene
    [SerializeField]
    public ObjectPositioing these_objects;
    [SerializeField]
    public EnergyTracker energyTracker;
    [SerializeField]
    public SliderState new_slide_state;

    private int check_on_exit = 0;

    public int Roomnum;


    //This can be in the new awake/start
    //private void Start()
    //{
    //    Roomnum = this_room.RoomNum;
    //}

    //Runs when the object is first activated within the scene
    //void Awake()
    //{
    //    //On the first activation runs the following code and functions
    //    if (energyTracker.My_firstPlay == true)
    //    {
    //        Debug.Log("Starting...\n");
    //        //firstPlay = false;
    //        energyTracker.My_firstPlay = false;
    //        //new_slide_state.StateProperty = false;
    //        this_room.SetupState();
    //    }
    //    else
    //    {
    //        Debug.Log("Running...\n");
    //        //Store the angle the lever was at after exit

    //        //Not super needed at the momenmt but I shall keep it in as its not that harmful at the moment
    //        lever.transform.position = these_objects.gameObjects[0].transform.position;
    //        lever.transform.rotation = these_objects.gameObjects[0].transform.rotation;

    //        //--------------------------
    //        //slider.transform.position = these_objects.gameObjects[1].transform.position;
    //        //slider.transform.rotation = these_objects.gameObjects[1].transform.rotation;
    //        //--------------------------

    //        //Checks if this room is active upon re-entry
    //        if (energyTracker.ActivatedProperty == true)
    //        {
    //            check_on_exit = 1;
    //        }
    //        else
    //        {
    //            check_on_exit = 0;
    //        }

    //        //Sets up the initial values for the room
    //        this_room.ActivateRoom(this, energyTracker.ActivatedProperty);
    //        this_room.SetupInitialEnergy(this, energyTracker.EnergyProperty);
    //    }
    //}

    ////When it is destroyed it is on
    //private void OnDestroy()
    //{
    //    //If the room is active upon re-entry when it goes to destroy itself it will set a value to say if it has remained on throughout its time within the room
    //    //This helps with totalling the energy within the overhead
    //    if (check_on_exit == 1)
    //    {
    //        energyTracker.My_ActiveOnEntryAndExit = true;
    //        check_on_exit = 0;
    //    }
    //}

    public void RunSetup()
    {
        Roomnum = this_room.RoomNum;

        if (energyTracker.My_firstPlay == true)
        {
            Debug.Log("Starting...\n");
            //firstPlay = false;
            energyTracker.My_firstPlay = false;
            //new_slide_state.StateProperty = false;
            this_room.first_run = true;
            this_room.SetupState();
        }
        else
        {
            Debug.Log("Running...\n");
            //Store the angle the lever was at after exit

            //Not super needed at the momenmt but I shall keep it in as its not that harmful at the moment
            //lever.transform.position = these_objects.gameObjects[0].transform.position;
            //lever.transform.rotation = these_objects.gameObjects[0].transform.rotation;

            //--------------------------
            //slider.transform.position = these_objects.gameObjects[1].transform.position;
            //slider.transform.rotation = these_objects.gameObjects[1].transform.rotation;
            //--------------------------

            //Checks if this room is active upon re-entry
            if (energyTracker.ActivatedProperty == true)
            {
                check_on_exit = 1;
            }
            else
            {
                check_on_exit = 0;
            }

            //Sets up the initial values for the room
            this_room.SetupInitialEnergy(this, energyTracker.EnergyProperty);
            this_room.ActivateRoom(this, energyTracker.ActivatedProperty);
        }
    }

    public void OnClose()
    {
        if (check_on_exit == 1)
        {
            energyTracker.My_ActiveOnEntryAndExit = true;
            check_on_exit = 0;
        }
    }

}