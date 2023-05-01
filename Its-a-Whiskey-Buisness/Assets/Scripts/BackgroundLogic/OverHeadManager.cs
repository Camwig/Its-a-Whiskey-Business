using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverHeadManager : MonoBehaviour
{
    //Refrence to the overhead function script
    public Overhead overhead_;

    //Overhead room energy tracker
    [SerializeField]
    public EnergyTracker OriginenergyTrack;

    //List of energy trackers for each room
    [SerializeField]
    private List<EnergyTracker> ListOfTrackers;

    //Arrays for each energy tracker to store their new and old amounts of energy
    public static float[] ListOfTrackers_amount;
    public static float[] ListOfTrackers_new_amount;

    //Currently not being used will remove later
    [SerializeField]
    public SliderState slide_state;
    public bool now_state;

    //Value for the overhead energy tacker old energy amount
    public static float OriginenergyTrack_amount;

    //Value for the overhead energy tacker new energy amount
    public float new_OriginenergyTrack_amount;

    //Boolean to keep track of if this is the first time running this block of code
    private static bool firstPlay = true;

    //This will always be zero as the overhead room is always room number zero
    private int RoomNum;

    //Refrence to the room state function that holds the enumeration values for the rooms we can enter
    [SerializeField]
    public CurrentRoom room_state;

    private void Awake()
    {
        //Initialises the arrays that hold the new and old energy amounts
        ListOfTrackers_amount =  new float[ListOfTrackers.Count];
        ListOfTrackers_new_amount = new float[ListOfTrackers.Count];

        //Calls the runsetup function
        RunSetup();
    }


    public void RunSetup()
    {
        //Sets the overhead manager to be the same room number as the overhead which will always be zero
        RoomNum = overhead_.RoomNum;

        //Sets the roomstate enumeration based off the room number
        room_state.SetRoom(RoomNum);

        //If this is the firts run of this function
        if (firstPlay == true)
        {
            //Initialises all these values as the scriptable objects would remeber the previous values on exit
            //This just makes sure all the values are reset
            //Debug.Log("Starting...\n");
            OriginenergyTrack.EnergyProperty = 0;
            OriginenergyTrack.IncreaseProperty = 1;
            OriginenergyTrack.ActivatedProperty = false;

            OriginenergyTrack.MyTemperature = 0.0f;

            slide_state.StateProperty = false;
            firstPlay = false;
            OriginenergyTrack.MyRoomNum = 0;
            OriginenergyTrack.OtherRoomProperty = false;

            for (int i = 0; i < ListOfTrackers.Count; i++)
            {
                ListOfTrackers[i].EnergyProperty = 0;
                ListOfTrackers[i].IncreaseProperty = 1;
                ListOfTrackers[i].ActivatedProperty = false;
                ListOfTrackers[i].My_firstPlay = true;
                ListOfTrackers[i].Energy_to_be_added_property = 0.0f;

                ListOfTrackers[i].MyTemperature = 0.0f;

                ListOfTrackers[i].My_ActiveOnEntryAndExit = false;
                ListOfTrackers[i].OtherRoomProperty = false;
                ListOfTrackers[i].MyRoomNum = i + 1;

                ListOfTrackers_amount[i] = 0.0f;
                ListOfTrackers_new_amount[i] = 0.0f;

            }

            //Calls some of the overheads setup functions
            overhead_.SetupEnergy();
            overhead_.Startup();
        }
        else
        {
            //If it is not the first time running this piece of code
            //Debug.Log("Running...\n");

            //Still not super used and is kind of redundant now juts havent had time to remove it yet
            now_state = slide_state.StateProperty;

            //Sets the origin energy amount to be the same amount upon the overheads exit
            OriginenergyTrack.EnergyProperty = OriginenergyTrack_amount;

            //Loops through all the energy trackes
            for (int i = 0; i < ListOfTrackers.Count; i++)
            {
                //Checks if certain criteria is met before entering the loop
                if (ListOfTrackers[i].ActivatedProperty == false || ListOfTrackers[i].My_ActiveOnEntryAndExit == true || ListOfTrackers[i].OtherRoomProperty == true)
                {
                    //Checks if the new amount of energy is greater than the old amount of energy
                    if (ListOfTrackers[i].EnergyProperty > ListOfTrackers_amount[i])
                    {
                        //Calculates the diffrence which is then set to be the amount of energy added to the overhead
                        ListOfTrackers_new_amount[i] = ListOfTrackers[i].EnergyProperty - ListOfTrackers_amount[i];
                        ListOfTrackers[i].Energy_to_be_added_property = ListOfTrackers_new_amount[i];

                        //if the room is not active on exit and was not active on entry
                        if (ListOfTrackers[i].ActivatedProperty == false && ListOfTrackers[i].My_ActiveOnEntryAndExit == false)
                        {
                            //Simply adds the whole new energy to the overhead
                            ListOfTrackers[i].EnergyProperty = ListOfTrackers[i].Energy_to_be_added_property;
                        }

                        //Resets certain variables that need resest
                        if (ListOfTrackers[i].OtherRoomProperty == true)
                        {
                            ListOfTrackers[i].OtherRoomProperty = false;
                        }
                    }
                }
                else
                {
                    //If none of the criteria are met simply add the whole energy amount to the overhead
                    //reseting the new and old amounts to zero
                    ListOfTrackers_amount[i] = 0.0f;
                    ListOfTrackers_new_amount[i] = 0.0f;
                    ListOfTrackers[i].Energy_to_be_added_property = ListOfTrackers[i].EnergyProperty;
                    ListOfTrackers[i].My_ActiveOnEntryAndExit = false;
                }
            }
        }
    }

    public void On_Close()
    {
        //Sets the old energy amount to be that of the amount upon the changing of rooms
        OriginenergyTrack_amount = OriginenergyTrack.EnergyProperty;
        slide_state.StateProperty = now_state;
        for (int i = 0; i < ListOfTrackers.Count; i++)
        {
            ListOfTrackers_amount[i] = ListOfTrackers[i].EnergyProperty;
            //Resets the energy to be added property
            ListOfTrackers[i].Energy_to_be_added_property = 0;
        }
    }
}