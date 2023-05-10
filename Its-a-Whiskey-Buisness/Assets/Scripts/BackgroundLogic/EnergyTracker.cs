using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cameron Wiggan

//Used to create assets of this scriptable object
//Which can be used as a type of object with the following variables/traits
[CreateAssetMenu]

public class EnergyTracker : ScriptableObject
{
    //propfull then double tap tab creates this quick varibale along with getters and setters.

    //Holds the amount of energy currently being generated by the trackers room.
    private float NewEnergy;
    public float EnergyProperty
    {
        get { return NewEnergy; }
        set { NewEnergy = value; }
    }

    //Represents the rate of the energy generated
    //(Multipiles the energy added by itself so it could be multiplied by 10 or 1 for example)
    private int RateOfIncrease;
    public int IncreaseProperty
    {
        get { return RateOfIncrease; }
        set { RateOfIncrease = value; }
    }

    //Variable to keep track of if the attached room/screen is generating energy
    private bool Activated;
    public bool ActivatedProperty
    {
        get { return Activated; }
        set { Activated = value; }
    }

    //Variable to keep track of if the attached room is being activated for the first time during the play session
    private bool first_play;
    public bool My_firstPlay
    {
        get { return first_play; }
        set { first_play = value; }
    }

    //Variable to keep track of if the Room attached is active and producing energy on entry to the room and when the room is exited
    private bool ActiveOnEntryAndExit;
    public bool My_ActiveOnEntryAndExit
    {
        get { return ActiveOnEntryAndExit; }
        set { ActiveOnEntryAndExit = value; }
    }

    //Variable to keep track of the energy that should be added to the overhead energy total on enetry to the overhead room
    //This value is calculated upon the overheads room activation.
    private float Energy_to_be_added;
    public float Energy_to_be_added_property
    {
        get { return Energy_to_be_added; }
        set { Energy_to_be_added = value; }
    }

    //Variable that keeps track of if the player enters a room other than our own or the overhead which is used as previously if energy was
    //previously being added it would add the rooms total energy again upon re-entering the overhead
    private bool EnteringRoomOtherthanUs;
    public bool OtherRoomProperty
    {
        get { return EnteringRoomOtherthanUs; }
        set { EnteringRoomOtherthanUs = value; }
    }

    //Variable that holds the Number Id for the room the Object is tracking the energy of
    private int RoomNum;
    public int MyRoomNum
    {
        get { return RoomNum; }
        set { RoomNum = value; }
    }

    //---Look into making all this nicer to use aswell as more efficeint
    //Will probably look into making the booleans that dont overlap with each other in this Object into
    //an enumerator which will just make it nicer to use.



    ///----------------Needing to add temperature
    private float Temperature;
    public float MyTemperature
    {
        get { return Temperature; }
        set { Temperature = value; }
    }
    ///

}
