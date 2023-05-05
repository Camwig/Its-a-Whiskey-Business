using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public Button EasyMode;
    public Button NormalMode;


    [SerializeField]
    public List<Objective> Objectives;

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

    private static bool easyOrNo;

    public List<bool> ObjectiveStop = new List<bool>();

    public float Times;

    [SerializeField]
    Mode modes;

    // Start is called before the first frame update
    void Start()
    {
        clock_ = this_clock.GetComponent<Clock>();

        modes.CheckMode();

        deductionValue = 0.0f;

        for(int k=0; k < Objectives.Count;k++)
        {
            Objectives[k].MyActivated = false;
            bool new_stuff = false;
            ObjectiveStop.Add(new_stuff);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //CheckMode();

        CheckObjectives();

        //Audio to let player know they are messing up

        textElement.text = deductionValue.ToString();
    }

    void CheckObjectives()
    {
        for (int h = 0; h < Objectives.Count; h++)
        {
            //X is hours and y is minutes

            //Keeps failing
            //Debug.Log(clock_.ReturnTime().x);

            if (ObjectiveStop[h] != true)
            {
                if (clock_.ReturnTime().x >= Objectives[h].MyStartingTime.x && clock_.ReturnTime().x <= Objectives[h].MyEndingTime.x)
                {
                    if(clock_.ReturnTime().y == Objectives[h].MyStartingTime.y && clock_.ReturnTime().y != Objectives[h].MyEndingTime.y)
                    {
                        ObjectiveStop[h] = true;
                    }
                }
            }
            
            if(ObjectiveStop[h] != false)
            {
                if (clock_.ReturnTime().x >= Objectives[h].MyEndingTime.x)
                {
                    if (clock_.ReturnTime().y >= Objectives[h].MyEndingTime.y)
                    {
                        ObjectiveStop[h] = false;
                    }
                }
            }

            //if (clock_.ReturnTime().x >= Objectives[h].MyStartingTime.x && clock_.ReturnTime().y >= Objectives[h].MyStartingTime.y)
            //{
            //    if (clock_.ReturnTime().x < Objectives[h].MyEndingTime.x && clock_.ReturnTime().y < Objectives[h].MyEndingTime.y)
            //    {
            if(ObjectiveStop[h]==true)
            {
                for (int j = 0; j < EnergyTrackers.Count; j++)
                {
                    if (EnergyTrackers[j].MyRoomNum == Objectives[h].MyRoomNum)
                    {
                        if (EnergyTrackers[j].ActivatedProperty != true)
                        {
                            Objectives[h].MyActivated = false;
                            deductionValue -= Times * Time.deltaTime;
                        }
                        else
                        {
                            Objectives[h].MyActivated = true;
                        }

                        if (Objectives[h].MyRateTrack == true)
                        {
                            if (EnergyTrackers[j].IncreaseProperty < Objectives[h].MyRateValue)
                            {
                                Objectives[h].MyActivated = false;
                                deductionValue -= Times * Time.deltaTime;
                            }
                        }

                        if (Objectives[h].MyTempTrack == true)
                        {
                            if (EnergyTrackers[j].MyTemperature != Objectives[h].MyTempValue)
                            {
                                Objectives[h].MyActivated = false;
                                deductionValue -= Times * Time.deltaTime;
                            }
                        }
                    }
                }
                //    }
                //}
            }
        }
    }

    //public void CheckMode()
    //{
    //    if (easyOrNo == true)
    //    {
    //        Times = 0.05f;
    //        //Debug.Log("0.05");
    //    }
    //    else
    //    {
    //        Times = 0.1f;
    //    }
    //}

    //public void IsEasy()
    //{
    //    if (EasyMode.GetComponent<Button>() == true)
    //    {
    //        //Times = 0.05f;
    //        //Debug.Log("0.05");
    //        easyOrNo = true;
    //    }
    //    else
    //    {
    //        easyOrNo = false;
    //        //Times = 0.1f;
    //    }
    //}

    //public void IsNormal()
    //{
    //    if (NormalMode.GetComponent<Button>() == true)
    //    {
    //        //Times = 0.1f;
    //        //Debug.Log("0.1");
    //        easyOrNo = false;
    //    }
    //    else
    //    {
    //        //Times = 0.1f;
    //        easyOrNo = false;
    //    }
    //}

    public bool AllObjectivesFailed()
    {
        int j = 0;
        bool retrunValue = false;
        for(int h=0; h< Objectives.Count;h++)
        {
            if(Objectives[h].MyActivated==false)
            {
                j++;
            }
        }

        if(j == Objectives.Count)
        {
            retrunValue = true;
        }

        return retrunValue;
    }

    public float RetrunDeduction()
    {
        return deductionValue;
    }

}

