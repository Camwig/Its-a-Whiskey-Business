using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

//Cameron Wiggan

public class Objective : ScriptableObject
{    
    //Starting time the objective should be active
    [SerializeField]
    private Vector2 StartingTime;

    public Vector2 MyStartingTime
    {
        get { return StartingTime; }
        set { StartingTime = value; }
    }

    //Time at which the objective ends being tracked
    [SerializeField]
    private Vector2 EndingTime;

    public Vector2 MyEndingTime
    {
        get { return EndingTime; }
        set { EndingTime = value; }
    }

    //Number of the room we are being tracked
    [SerializeField]
    private int RoomNum;

    public int MyRoomNum
    {
        get { return RoomNum; }
        set { RoomNum = value; }
    }

    //Boolean that tracks if the objective is being tracked
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

    //Tracks if the objective should keep a track of the rate of production
    [SerializeField]
    private bool RateTrack;

    public bool MyRateTrack
    {
        get { return RateTrack; }
        set { RateTrack = value; }
    }

    //Value at which the energy should produced at
    [SerializeField]
    private float RateValue;

    public float MyRateValue
    {
        get { return RateValue; }
        set { RateValue = value; }
    }

    //Tracks if the objective should keep a track of the temperature
    [SerializeField]
    private bool TempTrack;

    public bool MyTempTrack
    {
        get { return TempTrack; }
        set { TempTrack = value; }
    }

    //Value the temperarature should be at
    [SerializeField]
    private float TempValue;

    public float MyTempValue
    {
        get { return TempValue; }
        set { TempValue = value; }
    }

}
