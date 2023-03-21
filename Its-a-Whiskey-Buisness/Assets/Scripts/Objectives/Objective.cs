using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : ScriptableObject
{
    //Starting time - Done
    //Ending time - Done

    //The times should be the equivilent of an std::pair of floats one for hours and the other for minutes

    //Float modifier which will act as way to tell how well the player did depending on how high or low the value is.

    //What room needs to be on - DONE
    //What other settings need to be
        //Should have a way to describe as any.

        //List will expand as I go

        // -Energy activation

    

    private Dictionary<float,float> StartingTime;

    public Dictionary<float, float> MyStartingTime
    {
        get { return StartingTime; }
        set { StartingTime = value; }
    }

    private Dictionary<float, float> EndingTime;

    public Dictionary<float, float> MyEndingTime
    {
        get { return EndingTime; }
        set { EndingTime = value; }
    }

    //Number of the room that these apply to

    private int RoomNum;

    public int MyRoomNum
    {
        get { return RoomNum; }
        set { RoomNum = value; }
    }

    private bool Activated;

    public bool MyActivated
    {
        get { return Activated; }
        set { Activated = value; }
    }

    private float Modifier;

    public float MyModifier
    {
        get { return Modifier; }
        set { Modifier = value; }
    }


}
