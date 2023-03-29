//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;


//public class GenericRoom : MonoBehaviour
//{
//    //Energy variable being produced within the 'Room'
//    public float Energy;
//    //Enumerator states of the room
//    enum Room_state {Tracking_energy,Inactive,Ending_tracking};
//    //Current state of the room
//    private Room_state curr_state;
//    //String to be used to set the text
//    private string string_text;
//    //Variable to keep track of the rate at which the enrgy is produced
//    private int IncreaseProduct;

//    //public float Rate_of_production;
//    //public float Energy_consumption;

//    [SerializeField]
//    CurrentRoom this_room;

//    [SerializeField]
//    int RoomNum;

//    //Refrece to the text element within the room to display the energy generated by the room
//    public Text textelement;

//    //All the events that are raised within this object which are being listended for by other objects and scripts
//    //(Event systems are a way to call diffrent functions from scripts and object without this script containing a refrence to either that script or object)
//    [Header("Events")]
//    public EventSytem onEnergyChanged;
//    public EventSytem onActivation;
//    public EventSytem UpdateProductionRate;

//    // Start is called before the first frame update
//    void Start()
//    {
//        string_text = "Default";
//        IncreaseProduct = 1;
//    }

//    //public void Setting_factors(float New_rate, float New_Consumption)
//    //{
//    //    Rate_of_production = New_rate;
//    //    Energy_consumption = New_Consumption;
//    //}

//    //Function used to initialise some this rooms initial variables when it is first run
//    public void SetupState()
//    {
//        curr_state = Room_state.Inactive;
//        Energy = 0;
//    }

//    //Sets the energy of the room when the player enters it
//    //used for keeping energy consistent between overhead and each room
//    public void SetupInitialEnergy(Component sender, object data)
//    {
//       if(data is float)
//        {
//            Energy = (float)data;
//            //IncreaseProduct = 1;
//        }
//    }

//    //Function that is called from by the event listener
//    //used to activate the room
//    public void ActivateRoom(Component sender, object data)
//    {
//        //Checks if the data we are checking are booleans
//        if (data is bool)
//        {
//            bool on_off = (bool)data;

//            //Checks the boolean value
//            if (on_off == true)
//            {
//                //Sets the state of the room
//                curr_state = Room_state.Tracking_energy;
//            }
//            else if (on_off == false)
//            {
//                if (curr_state == Room_state.Tracking_energy)
//                {
//                    curr_state = Room_state.Ending_tracking;
//                }
//            }
//        }
//    }

//    //Function that is called from by the event listener
//    //used to increase the production
//    public void IncreaseProduction(Component sender, object data)
//    {
//        //Checks if the data we are checking are booleans
//        if (data is bool)
//        {
//            bool on_off = (bool)data;

//            //Checks the boolean value
//            if (on_off == true)
//            {
//                //Sets the Incriment value based off the boolean value
//                IncreaseProduct = 10;
//            }
//            else
//            {
//                IncreaseProduct = 1;
//            }
//            //Raises an event for the update production rate function
//            UpdateProductionRate.Raise(this, IncreaseProduct);
//        }
//    }

//    //Increases the energy of the room
//    private void IncreasseEnergy()
//    {
//        Energy += (0.001f * /*1*/IncreaseProduct) * Time.deltaTime;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        string_text = "Room Energy : " + Energy.ToString();
//        textelement.text = string_text;

//        //UpdateProductionRate.Raise(this, IncreaseProduct);

//        switch (curr_state)
//        {
//            case Room_state.Tracking_energy:
//                //Increase energy according to calculation
//                IncreasseEnergy();
//                //Raises the appropriate events
//                onEnergyChanged.Raise(this, Energy);
//                onActivation.Raise(this, true);
//                break;
//            case Room_state.Ending_tracking:
//                //Raises the appropriate event
//                onActivation.Raise(this, false);
//                Energy = 0;
//                curr_state = Room_state.Inactive;
//                //Stop the track of energy and pass it to the overhead
//                break;
//            case Room_state.Inactive:
//                //Idle
//                break;
//        }
//    }

//    //Update to be used later when we merge the builds
//    //void Update()
//    //{
//    //    if(this_room.GetRoom() == RoomNum)
//    //    {
//    //        Run_room();
//    //    }
//    //}

//    private void Run_room()
//    {
//        string_text = "Room Energy : " + Energy.ToString();
//        textelement.text = string_text;

//        //UpdateProductionRate.Raise(this, IncreaseProduct);

//        switch (curr_state)
//        {
//            case Room_state.Tracking_energy:
//                //Increase energy according to calculation
//                IncreasseEnergy();
//                //Raises the appropriate events
//                onEnergyChanged.Raise(this, Energy);
//                onActivation.Raise(this, true);
//                break;
//            case Room_state.Ending_tracking:
//                //Raises the appropriate event
//                onActivation.Raise(this, false);
//                Energy = 0;
//                curr_state = Room_state.Inactive;
//                //Stop the track of energy and pass it to the overhead
//                break;
//            case Room_state.Inactive:
//                //Idle
//                break;
//        }
//    }

//    public float GiveEnergy(float value)
//    {
//        return value;
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GenericRoom : MonoBehaviour
{
    //Energy variable being produced within the 'Room'
    public float Energy;
    //Enumerator states of the room
    enum Room_state { Tracking_energy, Inactive, Ending_tracking };
    //Current state of the room
    private Room_state curr_state;
    //String to be used to set the text
    private string string_text;
    //Variable to keep track of the rate at which the enrgy is produced
    private int IncreaseProduct;

    //public float Rate_of_production;
    //public float Energy_consumption;

    [SerializeField]
    CurrentRoom this_room;

    [SerializeField]
    public int RoomNum;

    //Refrece to the text element within the room to display the energy generated by the room
    public Text textelement;

    //All the events that are raised within this object which are being listended for by other objects and scripts
    //(Event systems are a way to call diffrent functions from scripts and object without this script containing a refrence to either that script or object)
    [Header("Events")]
    public EventSytem onEnergyChanged;
    public EventSytem onActivation;
    public EventSytem UpdateProductionRate;

    // Start is called before the first frame update
    void Start()
    {
        string_text = "Default";
        IncreaseProduct = 1;
    }

    //public void Setting_factors(float New_rate, float New_Consumption)
    //{
    //    Rate_of_production = New_rate;
    //    Energy_consumption = New_Consumption;
    //}

    //Function used to initialise some this rooms initial variables when it is first run
    public void SetupState()
    {
        curr_state = Room_state.Inactive;
        Energy = 0;
    }

    //Sets the energy of the room when the player enters it
    //used for keeping energy consistent between overhead and each room
    public void SetupInitialEnergy(Component sender, object data)
    {
        if (RoomNum == sender.GetComponent<LeverInteraction>().Room_num || RoomNum == sender.GetComponent<GenericRoomManager>().Roomnum)
        {
            if (data is float)
            {
                Energy = (float)data;
                //IncreaseProduct = 1;
            }
        }
    }

    //Function that is called from by the event listener
    //used to activate the room
    public void ActivateRoom(Component sender, object data)
    {
        //Checks if the data we are checking are booleans

        ////if(sender is LeverInteraction)
        ////{
        ////    if(sender.GetInstanceID)
        ////}

        //Error here
        if (RoomNum == sender.GetComponent<LeverInteraction>().Room_num || RoomNum == sender.GetComponent<GenericRoomManager>().Roomnum)
        {
            if (data is bool)
            {
                bool on_off = (bool)data;

                //Checks the boolean value
                if (on_off == true)
                {
                    //Sets the state of the room
                    curr_state = Room_state.Tracking_energy;
                }
                else if (on_off == false)
                {
                    if (curr_state == Room_state.Tracking_energy)
                    {
                        curr_state = Room_state.Ending_tracking;
                    }
                }
            }
        }
    }

    //Function that is called from by the event listener
    //used to increase the production
    public void IncreaseProduction(Component sender, object data)
    {
        //Checks if the data we are checking are booleans
        if (data is bool)
        {
            bool on_off = (bool)data;

            //Checks the boolean value
            if (on_off == true)
            {
                //Sets the Incriment value based off the boolean value
                IncreaseProduct = 10;
            }
            else
            {
                IncreaseProduct = 1;
            }
            //Raises an event for the update production rate function
            UpdateProductionRate.Raise(this, IncreaseProduct);
        }
    }

    //Increases the energy of the room
    private void IncreasseEnergy()
    {
        Energy += (0.001f * /*1*/IncreaseProduct) * Time.deltaTime;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    string_text = "Room Energy : " + Energy.ToString();
    //    textelement.text = string_text;

    //    //UpdateProductionRate.Raise(this, IncreaseProduct);

    //    switch (curr_state)
    //    {
    //        case Room_state.Tracking_energy:
    //            //Increase energy according to calculation
    //            IncreasseEnergy();
    //            //Raises the appropriate events
    //            onEnergyChanged.Raise(this, Energy);
    //            onActivation.Raise(this, true);
    //            break;
    //        case Room_state.Ending_tracking:
    //            //Raises the appropriate event
    //            onActivation.Raise(this, false);
    //            Energy = 0;
    //            curr_state = Room_state.Inactive;
    //            //Stop the track of energy and pass it to the overhead
    //            break;
    //        case Room_state.Inactive:
    //            //Idle
    //            break;
    //    }
    //}

    //Update to be used later when we merge the builds
    void Update()
    {
        if (this_room.GetRoom() == RoomNum)
        {
            Run_room();
        }
    }

    private void Run_room()
    {
        string_text = "Room Energy : " + Energy.ToString();
        textelement.text = string_text;

        //UpdateProductionRate.Raise(this, IncreaseProduct);

        switch (curr_state)
        {
            case Room_state.Tracking_energy:
                //Increase energy according to calculation
                IncreasseEnergy();
                //Raises the appropriate events

                //Never Being raised
                onEnergyChanged.Raise(this, Energy);
                onActivation.Raise(this, true);
                break;
            case Room_state.Ending_tracking:
                //Raises the appropriate event
                onActivation.Raise(this, false);
                Energy = 0;
                curr_state = Room_state.Inactive;
                //Stop the track of energy and pass it to the overhead
                break;
            case Room_state.Inactive:
                //Idle
                break;
        }
    }

    public float GiveEnergy(float value)
    {
        return value;
    }
}
