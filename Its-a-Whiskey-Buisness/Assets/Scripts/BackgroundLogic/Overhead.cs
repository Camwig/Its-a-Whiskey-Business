using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overhead : MonoBehaviour
{
    //Time function which I am unsure if it is still needed so I will look into removing it later
    private float time_;
    //Float value to represent the overall energy
    private static float Overall_Energy;
    //String variables to output to the text elements
    private string string_text;
    private string string_room1;
    private string string_room2;
    private string string_room3;
    private string string_room4;

    //Text elements
    public Text textelement;
    //public Text textRoom1;
    //public Text textRoom2;
    //public Text textRoom3;
    //public Text textRoom4;

    //I am unsure if this needed aswell so I will into removing this later
    public static Overhead New_Instance;

    //additive value to calculate the value to be added to the energy trackers
    private float additive;

    //Energy tracker to keep track of the overall energy
    [SerializeField]
    private EnergyTracker OriginEnergyTrack;

    //List that stores all the energy trackers
    [SerializeField]
    private List<EnergyTracker> ListOfTrackers;

    //Refrence to the Current room script and object
    [SerializeField]
    CurrentRoom this_room;

    //Will be set to zero as the overhead room will always be considered room zero
    [SerializeField]
    public int RoomNum;

    //Awake function to reset the overall energy
    private void Awake()
    {
        Overall_Energy = 0;
    }

    //Simple function to call the overall energy to be set to zero
    public void SetupEnergy()
    {
        Overall_Energy = 0;
    }

    //I do not beleive we need both so I will add this to the list of things Im keeping right
    //now as Im simly to anxious to get rid of them at the moment

    //Startup function
    public void Startup()
    {
        //Resets additive
        time_ = 0;
        string_text = "Default";
        additive = 0;

        //Sets the overall energy to be that of the energy in the overhead energy tracker
        Overall_Energy = OriginEnergyTrack.EnergyProperty;

        for (int i =0; i < ListOfTrackers.Count; i++)
        {
            //Adds the energy to be added values of the other energy trackers
            Overall_Energy += ListOfTrackers[i].Energy_to_be_added_property;

            //Resets the energy property if the energy tracker is off
            if (!ListOfTrackers[i].ActivatedProperty)
            {
                ListOfTrackers[i].EnergyProperty = 0;
            }
        }
    }

    void RunRoom()
    {
        //Updates the text elements with the energy properties
        if (time_ < 100.0f)
        {
            time_ += Time.deltaTime;
            string_text = Overall_Energy.ToString();
            textelement.text = "Overall Energy : " + string_text;

            //string_room1 = ListOfTrackers[0].EnergyProperty.ToString();
            //textRoom1.text = string_room1;

            //string_room2 = ListOfTrackers[1].EnergyProperty.ToString();
            //textRoom2.text = string_room2;

            //string_room3 = ListOfTrackers[2].EnergyProperty.ToString();
            //textRoom3.text = string_room3;

            //string_room4 = ListOfTrackers[3].EnergyProperty.ToString();
            //textRoom4.text = string_room4;
        }

        //Loop through each energy tracker
        for (int i = 0; i < ListOfTrackers.Count; i++)
        {
            //If it is currently active
            if (ListOfTrackers[i].ActivatedProperty == true)
            {
                //Calculate the additive
                additive = (0.1f * ListOfTrackers[i].IncreaseProperty) * Time.deltaTime;

                //Add it to the energy of the room and the overall seperatley
                Overall_Energy += additive;
                ListOfTrackers[i].EnergyProperty += additive;
            }
            else
            {
                //If the energy tracker is not active reset the additive
                additive = 0.0f;
            }

            //Resets the energy property if the energy tracker is off
            if (!ListOfTrackers[i].ActivatedProperty)
            {
                ListOfTrackers[i].EnergyProperty = 0;
            }
        }

        //Sets the overhead energy to be the new value of the overall energy
        OriginEnergyTrack.EnergyProperty = Overall_Energy;
    }

    //Add energy function
    //Ill be fully honest I am not sure how this got here
    public void AddEnergy(Component sender, object data)
    {
        if (RoomNum == sender.GetComponent<LeverInteraction>().Room_num)
        {
            if (data is float)
            {
                float energy = (float)data;
                Overall_Energy += energy;
            }
        }
    }

    //Update function
    void Update()
    {
        RunRoom();
    }

    public float returnEnergy()
    {
        return Overall_Energy;
    }
}