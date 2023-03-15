using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnergyTracker : ScriptableObject
{
    //propfull then double tap tab

    private float NewEnergy;

    public float EnergyProperty
    {
        get { return NewEnergy; }
        set { NewEnergy = value; }
    }

    private int RateOfIncrease;

    public int IncreaseProperty
    {
        get { return RateOfIncrease; }
        set { RateOfIncrease = value; }
    }


    private bool Activated;

    public bool ActivatedProperty
    {
        get { return Activated; }
        set { Activated = value; }
    }

    private bool first_play;

    public bool My_firstPlay
    {
        get { return first_play; }
        set { first_play = value; }
    }

    private bool ActiveOnEntryAndExit;

    public bool My_ActiveOnEntryAndExit
    {
        get { return ActiveOnEntryAndExit; }
        set { ActiveOnEntryAndExit = value; }
    }


    //private void OnValidate()
    //{
    //    DontDestroyOnLoad(this);
    //}

}
