using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveSystem : MonoBehaviour
{
    //Objectives that it needs to track
    //Array of objectives
    //Check the array and the time 
    //When we get to point we need to check its starting time we need to look at its tracker to see if it is being met
    //for now we can punish the player by generating an extra score to give them negative points while the task is not being done
    //Need it to track the time so we can tell when it gets to a certain point to compare the players energy used against the minimum


    //Need to have a refrence to each energy tracker including the overhead one.
    //Have a list of objectives that need to be cycled through to check that stuff is being done
    //A value which is the best possible result for the day.

    //Define the best possible result

    //While it is between 9am and 5pm loop through each objective
    //if it is greater than or equal to that objectives starting time and not greater than its ending time
    //Check that objectives room number 
    //Check the corresponding room tracker and if its not all met
    //increase/decrease a value which will act as a general negative modifier.
    //Can put this out to text for the moment


    [SerializeField]
    List<Objective> Objectives;

    [SerializeField]
    List<EnergyTracker> EnergyTrackers;

    [SerializeField]
    EnergyTracker OverheadTracker;

    [SerializeField]
    GameObject this_clock;
    Clock clock_;

    [SerializeField]
    TMP_Text textElement;

    private float deductionValue;


    // Start is called before the first frame update
    void Start()
    {
        clock_ = this_clock.GetComponent<Clock>();

        deductionValue = 0.0f;

        for(int k=0; k < Objectives.Count;k++)
        {
            Objectives[k].MyActivated = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckObjectives();

        textElement.text = deductionValue.ToString();
    }

    void CheckObjectives()
    {
        for (int h = 0; h < Objectives.Count; h++)
        {
            //X is hours and y is minutes
            if (clock_.ReturnTime().x >= Objectives[h].MyStartingTime.x && clock_.ReturnTime().x < Objectives[h].MyEndingTime.x)
            {
                if (clock_.ReturnTime().y >= Objectives[h].MyStartingTime.y && clock_.ReturnTime().y < Objectives[h].MyEndingTime.y)
                {
                    for (int j = 0; j < EnergyTrackers.Count; j++)
                    {
                        if (EnergyTrackers[j].MyRoomNum == Objectives[h].MyRoomNum)
                        {
                            if (EnergyTrackers[j].ActivatedProperty != true)
                            {
                                Objectives[h].MyActivated = false;
                                deductionValue -= 0.1f * Time.deltaTime;
                            }
                            else
                            {
                                Objectives[h].MyActivated = true;
                            }

                            if(Objectives[h].MyRateTrack == true)
                            {
                                if(EnergyTrackers[j].IncreaseProperty != Objectives[h].MyRateValue)
                                {
                                    Objectives[h].MyActivated = false;
                                    deductionValue -= 0.1f * Time.deltaTime;
                                }
                            }

                            if (Objectives[h].MyTempTrack == true)
                            {
                                if (EnergyTrackers[j].MyTemperature != Objectives[h].MyTempValue)
                                {
                                    Objectives[h].MyActivated = false;
                                    deductionValue -= 0.1f * Time.deltaTime;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
