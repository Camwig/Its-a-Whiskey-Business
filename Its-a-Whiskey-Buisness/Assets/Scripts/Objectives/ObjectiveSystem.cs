using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectiveSystem : MonoBehaviour
{
    //Button to set easy mode and normal mode
    public Button EasyMode;
    public Button NormalMode;

    //List of objectives assets
    [SerializeField]
    public List<Objective> Objectives;

    //List of the energy trackers needing to be tracked
    [SerializeField]
    List<EnergyTracker> EnergyTrackers;

    //Energy tracker for the overhead
    [SerializeField]
    EnergyTracker OverheadTracker;

    //Clock gameobjects
    [SerializeField]
    GameObject this_clock;
    Clock clock_;

    //Textelement for the objective system
    [SerializeField]
    TMP_Text textElement;

    //Deduction value to affect the final output of the energy
    private float deductionValue;

    //List of booleans that check if the objectives have been activated
    public List<bool> ObjectiveStop = new List<bool>();

    //The value that will deduct towards the deduction value (Will change based on difficulty)
    public float Times;

    //Modes gameobject
    [SerializeField]
    Mode modes;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the correct clock component
        clock_ = this_clock.GetComponent<Clock>();

        //Calls the check mode function
        modes.CheckMode();

        //Sets the deduction value to zero
        deductionValue = 0.0f;

        //Loops for the amount of objectives
        for(int k=0; k < Objectives.Count;k++)
        {
            //Set them to be inactive
            Objectives[k].MyActivated = false;
            //Sets each objective stop value to false
            bool new_stuff = false;
            ObjectiveStop.Add(new_stuff);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Checking each objective function
        CheckObjectives();

        //Sets the newValue rounded to the closest decimal place
        //and outputs it to the text element
        float newValue = Mathf.Round(deductionValue);

        textElement.text = "Missed Production : " + newValue.ToString();
    }

    void CheckObjectives()
    {
        //Loops through every objective
        for (int h = 0; h < Objectives.Count; h++)
        {
            //Checks if the appropriate objective stop value is false
            if (ObjectiveStop[h] != true)
            {
                //Checks if the current hour in time is greater than or equal to the starting time and less than or equal to the ending time
                if (clock_.ReturnTime().x >= Objectives[h].MyStartingTime.x && clock_.ReturnTime().x <= Objectives[h].MyEndingTime.x)
                {
                    //Checks if the current minute in time is equal to the starting time and not equal to the ending time
                    if(clock_.ReturnTime().y == Objectives[h].MyStartingTime.y && clock_.ReturnTime().y != Objectives[h].MyEndingTime.y)
                    {
                        //Means the objective is active
                        //Sets the appropriate value to true
                        ObjectiveStop[h] = true;
                    }
                }
            }
            
            //Checks if the objective is equal to true
            if(ObjectiveStop[h] != false)
            {
                //Checks if the hour and the minute are greater than or equal to the ending time
                if (clock_.ReturnTime().x >= Objectives[h].MyEndingTime.x)
                {
                    if (clock_.ReturnTime().y >= Objectives[h].MyEndingTime.y)
                    {
                        //If the conditions are met
                        //Set them to false
                        ObjectiveStop[h] = false;
                    }
                }
            }

            //If the appropriate objectivestop is equal to true
            if(ObjectiveStop[h]==true)
            {
                //Loops through every energy tracker
                for (int j = 0; j < EnergyTrackers.Count; j++)
                {
                    //Checks if the current energy trackers room is equal to the room number of the objective
                    if (EnergyTrackers[j].MyRoomNum == Objectives[h].MyRoomNum)
                    {
                        //Checks if it is active
                        if (EnergyTrackers[j].ActivatedProperty != true)
                        {
                            //If it is not active set the objective to false
                            Objectives[h].MyActivated = false;
                            //and decrease the deduction value
                            deductionValue -= Times * Time.deltaTime;
                        }
                        else
                        {
                            //If it is on then the objective is set to true
                            Objectives[h].MyActivated = true;
                        }

                        //Checks if the energy rate is part of the objective
                        if (Objectives[h].MyRateTrack == true)
                        {
                            //Checks if the energy tracker rate of energy production is less than the objectives value
                            if (EnergyTrackers[j].IncreaseProperty < Objectives[h].MyRateValue)
                            {
                                //Sets the objective to not being met
                                Objectives[h].MyActivated = false;
                                //and decrease the deduction value
                                deductionValue -= Times * Time.deltaTime;
                            }
                        }

                        //Checks if the temperature is part of the objective
                        if (Objectives[h].MyTempTrack == true)
                        {
                            //Checks if the energy tracker temperature is not equal to the objectives value
                            if (EnergyTrackers[j].MyTemperature != Objectives[h].MyTempValue)
                            {
                                //Sets the objective to not being met
                                Objectives[h].MyActivated = false;
                                //and decrease the deduction value
                                deductionValue -= Times * Time.deltaTime;
                            }
                        }
                    }
                }
            }
        }
    }
    public bool AllObjectivesFailed()
    {
        int j = 0;
        bool retrunValue = false;
        //Loops through each objective
        for(int h=0; h< Objectives.Count;h++)
        {
            //If  the current objective is false
            if(Objectives[h].MyActivated==false)
            {
                //increas the count
                j++;
            }
        }

        //If after looping through every objective
        //the count is equal to all the objectives

        //It means everyone of them was missed
        if(j == Objectives.Count)
        {
            //And sets the return value appropriatley
            retrunValue = true;
        }

        return retrunValue;
    }

    public float RetrunDeduction()
    {
        return deductionValue;
    }

}

