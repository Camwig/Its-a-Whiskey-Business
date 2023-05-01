using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

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

    
    [SerializeField]
    private Vector2 StartingTime;

    public Vector2 MyStartingTime
    {
        get { return StartingTime; }
        set { StartingTime = value; }
    }

    [SerializeField]
    private Vector2 EndingTime;

    public Vector2 MyEndingTime
    {
        get { return EndingTime; }
        set { EndingTime = value; }
    }

    //Number of the room that these apply to

    [SerializeField]
    private int RoomNum;

    public int MyRoomNum
    {
        get { return RoomNum; }
        set { RoomNum = value; }
    }

    [SerializeField]
    private bool Activated;

    public bool MyActivated
    {
        get { return Activated; }
        set { Activated = value; }
    }

    [SerializeField]
    private float Modifier;

    public float MyModifier
    {
        get { return Modifier; }
        set { Modifier = value; }
    }

    //Need to have thing to say if you need to track energy rate  and/or temperature

    [SerializeField]
    private bool RateTrack;

    public bool MyRateTrack
    {
        get { return RateTrack; }
        set { RateTrack = value; }
    }

    [SerializeField]
    private float RateValue;

    public float MyRateValue
    {
        get { return RateValue; }
        set { RateValue = value; }
    }

    [SerializeField]
    private bool TempTrack;

    public bool MyTempTrack
    {
        get { return TempTrack; }
        set { TempTrack = value; }
    }

    [SerializeField]
    private float TempValue;

    public float MyTempValue
    {
        get { return TempValue; }
        set { TempValue = value; }
    }

}
