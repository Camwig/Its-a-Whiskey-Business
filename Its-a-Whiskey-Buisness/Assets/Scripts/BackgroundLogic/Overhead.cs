////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;
////using UnityEngine.UI;

//////Version 1 for the initial milestone

////public class Overhead : MonoBehaviour
////{
////    //public EventHandler OnEnergyChanged;

////    //Replace later with clock function
////    private float time_;
////    private float Overall_Energy;
////    private string string_text;

////    public Text textelement;

////    public static Overhead New_Instance;

////    //Need a variable to track the overall amount for each room rather than adding it
////    // to the main overall as that is just going to combine their outputs

////    //Plan is to keep track of each energy tracker that is attached to a room in an array

////    //private float EnergyRoom1;
////    //private float EnergyRoom2;
////    private float additive;

////    [SerializeField]
////    private EnergyTracker energyTrack;
////    [SerializeField]
////    private EnergyTracker OriginEnergyTrack;
////    [SerializeField]
////    private EnergyTracker energyTrack2;

////    //private void Awake()
////    //{
////    //    if (New_Instance != null)
////    //    {
////    //        Destroy(gameObject);
////    //        return;
////    //    }

////    //    New_Instance = this;
////    //    DontDestroyOnLoad(gameObject);
////    //}

////    // Start is called before the first frame update
////    void Start()
////    {
////        time_ = 0;
////        //Overall_Energy =0;
////        string_text = "Default";

////        //EnergyRoom1 = energyTrack.EnergyProperty;
////        //EnergyRoom2 = energyTrack2.EnergyProperty;
////        additive = 0;

////        Overall_Energy = OriginEnergyTrack.EnergyProperty;



////        //Once its been added I need to clear the added energy property especially if it is off

////        Overall_Energy += energyTrack.EnergyProperty;

////        Overall_Energy += energyTrack2.EnergyProperty;

////        if (!energyTrack.ActivatedProperty)
////        {
////            energyTrack.EnergyProperty = 0;
////        }

////        if (!energyTrack2.ActivatedProperty)
////        {
////            energyTrack2.EnergyProperty = 0;
////        }

////        OriginEnergyTrack.EnergyProperty = Overall_Energy;

////       // Overall_Energy = PlayerPrefs.GetFloat("Overall_energy");
////        //Overall_Energy += PlayerPrefs.GetFloat("Energy");
////    }

////    // Update is called once per frame
////    void Update()
////    {
////        //Check clock

////        //How much energy consumed

////        //While it is not the end of the day keep tracking the energy

////        //if(MainManager.Instance != null)
////        //{
////        //    Overall_Energy += MainManager.Instance.ReturnEnergy();
////        //    MainManager.Instance = null;
////        //    Destroy(            MainManager.Instance);
////        //}

////        if(time_ < 100.0f)
////        {
////            time_ += Time.deltaTime;
////            //Debug.Log(Overall_Energy);
////            string_text = "Overall Energy : " + Overall_Energy.ToString();
////            textelement.text = string_text;
////        }

////        //Overall_Energy += energyTrack.EnergyProperty;

////        //PlayerPrefs.SetFloat("Overall_energy", Overall_Energy);

////        //Loop through each item in enrgy tracker array

////        //switch (energyTrack.ActivatedProperty)
////        //{
////        //    case true:
////        //        //Calculate the additive
////        //        additive += 0.1f * energyTrack.IncreaseProperty;


////        //        //energyTrack.EnergyProperty += 0.1f * energyTrack.IncreaseProperty;


////        //        //Add it to the energy of the room and the overall seperatley

////        //        Overall_Energy += additive;
////        //        energyTrack.EnergyProperty += additive;

////        //        //Overall_Energy = energyTrack.EnergyProperty;


////        //        //OriginEnergyTrack.EnergyProperty = Overall_Energy;
////        //        break;
////        //    case false:
////        //        OriginEnergyTrack.EnergyProperty = Overall_Energy;
////        //        break;
////        //}

////        if(energyTrack.ActivatedProperty == true)
////        {
////            //Calculate the additive
////            additive = 0.1f * energyTrack.IncreaseProperty;
////            //Add it to the energy of the room and the overall seperatley
////            Overall_Energy += additive;
////            energyTrack.EnergyProperty += additive;
////        }

////        if (energyTrack2.ActivatedProperty ==true)
////        {
////            additive = 0.1f * energyTrack2.IncreaseProperty;
////            Overall_Energy += additive;
////            energyTrack2.EnergyProperty += additive;
////        }

////        OriginEnergyTrack.EnergyProperty = Overall_Energy;


////        //Overall_Energy += energyTrack.EnergyProperty;
////        //energyTrack2.EnergyProperty = Overall_Energy;
////    }


////    public void AddEnergy(Component sender, object data)
////    {
////        if (data is float)
////        {
////            float energy = (float)data;
////            Overall_Energy += energy;
////            //Debug.Log("ASASHSAJBSh\n");
////        }
////    }

////    public void SetEnergy(float new_value)
////    {
////        Overall_Energy = new_value;
////    }


////    //public void AddEnergytototal(float new_energy)
////    //{
////    //    Overall_Energy += new_energy;
////    //    if (OnEnergyChanged != null) OnEnergyChanged(null, EventArgs.Empty);
////    //}
////}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

////Version 1 for the initial milestone

//public class Overhead : MonoBehaviour
//{
//    //public EventHandler OnEnergyChanged;

//    //Replace later with clock function
//    private float time_;
//    private static float Overall_Energy;
//    private string string_text;

//    private string string_room1;
//    private string string_room2;

//    public Text textelement;

//    public Text textRoom1;
//    public Text textRoom2;

//    public static Overhead New_Instance;

//    //Need a variable to track the overall amount for each room rather than adding it
//    // to the main overall as that is just going to combine their outputs

//    //Plan is to keep track of each energy tracker that is attached to a room in an array

//    //private float EnergyRoom1;
//    //private float EnergyRoom2;
//    private float additive;

//    [SerializeField]
//    private EnergyTracker energyTrack;

//    //------------------------------------------
//    [SerializeField]
//    private EnergyTracker energyTrack2;
//    //------------------------------------------

//    [SerializeField]
//    private EnergyTracker OriginEnergyTrack;
//    //[SerializeField]
//    //private EnergyTracker energyTrack2;

//    //private void Awake()
//    //{
//    //    if (New_Instance != null)
//    //    {
//    //        Destroy(gameObject);
//    //        return;
//    //    }

//    //    New_Instance = this;
//    //    DontDestroyOnLoad(gameObject);
//    //}

//    // Start is called before the first frame update

//    [SerializeField]
//    CurrentRoom this_room;

//    [SerializeField]
//    int RoomNum;

//    private void Awake()
//    {
//        Overall_Energy = 0;
//    }

//    public void SetupEnergy()
//    {
//        Overall_Energy = 0;
//    }

//    public void Startup()
//    {
//        time_ = 0;
//        //Overall_Energy =0;
//        string_text = "Default";

//        //EnergyRoom1 = energyTrack.EnergyProperty;
//        //EnergyRoom2 = energyTrack2.EnergyProperty;
//        additive = 0;

//        Overall_Energy = OriginEnergyTrack.EnergyProperty;



//        //Once its been added I need to clear the added energy property especially if it is off

//        //Overall_Energy += energyTrack.EnergyProperty;
//        Overall_Energy += energyTrack.Energy_to_be_added_property;

//        //------------------------------------------
//        //Overall_Energy += energyTrack2.EnergyProperty;
//        Overall_Energy += energyTrack2.Energy_to_be_added_property;
//        //------------------------------------------

//        if (!energyTrack.ActivatedProperty)
//        {
//            energyTrack.EnergyProperty = 0;
//        }

//        //------------------------------------------
//        if (!energyTrack2.ActivatedProperty)
//        {
//            energyTrack2.EnergyProperty = 0;
//        }
//        //------------------------------------------

//        //OriginEnergyTrack.EnergyProperty = Overall_Energy;

//        // Overall_Energy = PlayerPrefs.GetFloat("Overall_energy");
//        //Overall_Energy += PlayerPrefs.GetFloat("Energy");
//    }

//    void Start()
//    {
//        time_ = 0;
//        //Overall_Energy =0;
//        string_text = "Default";

//        //EnergyRoom1 = energyTrack.EnergyProperty;
//        //EnergyRoom2 = energyTrack2.EnergyProperty;
//        additive = 0;

//        Overall_Energy = OriginEnergyTrack.EnergyProperty;



//        //Once its been added I need to clear the added energy property especially if it is off

//        //Overall_Energy += energyTrack.EnergyProperty;
//        Overall_Energy += energyTrack.Energy_to_be_added_property;

//        //------------------------------------------
//        //Overall_Energy += energyTrack2.EnergyProperty;
//        Overall_Energy += energyTrack2.Energy_to_be_added_property;
//        //------------------------------------------

//        if (!energyTrack.ActivatedProperty)
//        {
//            energyTrack.EnergyProperty = 0;
//        }

//        //------------------------------------------
//        if (!energyTrack2.ActivatedProperty)
//        {
//            energyTrack2.EnergyProperty = 0;
//        }
//        //------------------------------------------

//        //OriginEnergyTrack.EnergyProperty = Overall_Energy;

//        // Overall_Energy = PlayerPrefs.GetFloat("Overall_energy");
//        //Overall_Energy += PlayerPrefs.GetFloat("Energy");
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //Check clock

//        //How much energy consumed

//        //While it is not the end of the day keep tracking the energy

//        //if(MainManager.Instance != null)
//        //{
//        //    Overall_Energy += MainManager.Instance.ReturnEnergy();
//        //    MainManager.Instance = null;
//        //    Destroy(            MainManager.Instance);
//        //}

//        if (time_ < 100.0f)
//        {
//            time_ += Time.deltaTime;
//            //Debug.Log(Overall_Energy);
//            string_text = Overall_Energy.ToString();
//            textelement.text = string_text;

//            string_room1 = energyTrack.EnergyProperty.ToString();
//            textRoom1.text = string_room1;

//            string_room2 = energyTrack2.EnergyProperty.ToString();
//            textRoom2.text = string_room2;
//        }

//        //Overall_Energy += energyTrack.EnergyProperty;

//        //PlayerPrefs.SetFloat("Overall_energy", Overall_Energy);

//        //Loop through each item in enrgy tracker array

//        //switch (energyTrack.ActivatedProperty)
//        //{
//        //    case true:
//        //        //Calculate the additive
//        //        additive += 0.1f * energyTrack.IncreaseProperty;


//        //        //energyTrack.EnergyProperty += 0.1f * energyTrack.IncreaseProperty;


//        //        //Add it to the energy of the room and the overall seperatley

//        //        Overall_Energy += additive;
//        //        energyTrack.EnergyProperty += additive;

//        //        //Overall_Energy = energyTrack.EnergyProperty;


//        //        //OriginEnergyTrack.EnergyProperty = Overall_Energy;
//        //        break;
//        //    case false:
//        //        OriginEnergyTrack.EnergyProperty = Overall_Energy;
//        //        break;
//        //}

//        if (energyTrack.ActivatedProperty == true)
//        {
//            //Calculate the additive
//            additive = (0.001f * energyTrack.IncreaseProperty) * Time.deltaTime;
//            //Add it to the energy of the room and the overall seperatley
//            Overall_Energy += additive;
//            energyTrack.EnergyProperty += additive;
//        }
//        else
//        {
//            additive = 0.0f;
//        }

//        //------------------------------------------
//        if (energyTrack2.ActivatedProperty == true)
//        {
//            //Calculate the additive

//            //Increase property has defaulted to zero for some reason
//            additive = (0.001f * energyTrack2.IncreaseProperty) * Time.deltaTime;

//            //Add it to the energy of the room and the overall seperatley
//            Overall_Energy += additive;
//            energyTrack2.EnergyProperty += additive;
//        }
//        else
//        {
//            additive = 0.0f;
//        }
//        //------------------------------------------

//        //if (energyTrack2.ActivatedProperty == true)
//        //{
//        //    additive = 0.1f * energyTrack2.IncreaseProperty;
//        //    Overall_Energy += additive;
//        //    energyTrack2.EnergyProperty += additive;
//        //}

//        OriginEnergyTrack.EnergyProperty = Overall_Energy;


//        //Overall_Energy += energyTrack.EnergyProperty;
//        //energyTrack2.EnergyProperty = Overall_Energy;
//    }

//    ////Update to be run in stable with the one room
//    //void Update()
//    //{
//    //    if(this_room.GetRoom() == RoomNum)
//    //    {
//    //        RunRoom();
//    //    }
//    //}

//    void RunRoom()
//    {
//        //Check clock

//        //How much energy consumed

//        //While it is not the end of the day keep tracking the energy

//        //if(MainManager.Instance != null)
//        //{
//        //    Overall_Energy += MainManager.Instance.ReturnEnergy();
//        //    MainManager.Instance = null;
//        //    Destroy(            MainManager.Instance);
//        //}

//        if (time_ < 100.0f)
//        {
//            time_ += Time.deltaTime;
//            //Debug.Log(Overall_Energy);
//            string_text = Overall_Energy.ToString();
//            textelement.text = string_text;

//            string_room1 = energyTrack.EnergyProperty.ToString();
//            textRoom1.text = string_room1;

//            string_room2 = energyTrack2.EnergyProperty.ToString();
//            textRoom2.text = string_room2;
//        }

//        //Overall_Energy += energyTrack.EnergyProperty;

//        //PlayerPrefs.SetFloat("Overall_energy", Overall_Energy);

//        //Loop through each item in enrgy tracker array

//        //switch (energyTrack.ActivatedProperty)
//        //{
//        //    case true:
//        //        //Calculate the additive
//        //        additive += 0.1f * energyTrack.IncreaseProperty;


//        //        //energyTrack.EnergyProperty += 0.1f * energyTrack.IncreaseProperty;


//        //        //Add it to the energy of the room and the overall seperatley

//        //        Overall_Energy += additive;
//        //        energyTrack.EnergyProperty += additive;

//        //        //Overall_Energy = energyTrack.EnergyProperty;


//        //        //OriginEnergyTrack.EnergyProperty = Overall_Energy;
//        //        break;
//        //    case false:
//        //        OriginEnergyTrack.EnergyProperty = Overall_Energy;
//        //        break;
//        //}

//        if (energyTrack.ActivatedProperty == true)
//        {
//            //Calculate the additive
//            additive = (0.001f * energyTrack.IncreaseProperty) * Time.deltaTime;
//            //Add it to the energy of the room and the overall seperatley
//            Overall_Energy += additive;
//            energyTrack.EnergyProperty += additive;
//        }
//        else
//        {
//            additive = 0.0f;
//        }

//        //------------------------------------------
//        if (energyTrack2.ActivatedProperty == true)
//        {
//            //Calculate the additive

//            //Increase property has defaulted to zero for some reason
//            additive = (0.001f * energyTrack2.IncreaseProperty) * Time.deltaTime;

//            //Add it to the energy of the room and the overall seperatley
//            Overall_Energy += additive;
//            energyTrack2.EnergyProperty += additive;
//        }
//        else
//        {
//            additive = 0.0f;
//        }
//        //------------------------------------------

//        //if (energyTrack2.ActivatedProperty == true)
//        //{
//        //    additive = 0.1f * energyTrack2.IncreaseProperty;
//        //    Overall_Energy += additive;
//        //    energyTrack2.EnergyProperty += additive;
//        //}

//        OriginEnergyTrack.EnergyProperty = Overall_Energy;


//        //Overall_Energy += energyTrack.EnergyProperty;
//        //energyTrack2.EnergyProperty = Overall_Energy;
//    }


//    public void AddEnergy(Component sender, object data)
//    {
//        if (data is float)
//        {
//            float energy = (float)data;
//            Overall_Energy += energy;
//            //Debug.Log("ASASHSAJBSh\n");
//        }
//    }

//    //public void SetEnergy(float new_value)
//    //{
//    //    Overall_Energy = new_value;
//    //}


//    //public void AddEnergytototal(float new_energy)
//    //{
//    //    Overall_Energy += new_energy;
//    //    if (OnEnergyChanged != null) OnEnergyChanged(null, EventArgs.Empty);
//    //}
//}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

////Version 1 for the initial milestone

//public class Overhead : MonoBehaviour
//{
//    //public EventHandler OnEnergyChanged;

//    //Replace later with clock function
//    private float time_;
//    private float Overall_Energy;
//    private string string_text;

//    public Text textelement;

//    public static Overhead New_Instance;

//    //Need a variable to track the overall amount for each room rather than adding it
//    // to the main overall as that is just going to combine their outputs

//    //Plan is to keep track of each energy tracker that is attached to a room in an array

//    //private float EnergyRoom1;
//    //private float EnergyRoom2;
//    private float additive;

//    [SerializeField]
//    private EnergyTracker energyTrack;
//    [SerializeField]
//    private EnergyTracker OriginEnergyTrack;
//    [SerializeField]
//    private EnergyTracker energyTrack2;

//    //private void Awake()
//    //{
//    //    if (New_Instance != null)
//    //    {
//    //        Destroy(gameObject);
//    //        return;
//    //    }

//    //    New_Instance = this;
//    //    DontDestroyOnLoad(gameObject);
//    //}

//    // Start is called before the first frame update
//    void Start()
//    {
//        time_ = 0;
//        //Overall_Energy =0;
//        string_text = "Default";

//        //EnergyRoom1 = energyTrack.EnergyProperty;
//        //EnergyRoom2 = energyTrack2.EnergyProperty;
//        additive = 0;

//        Overall_Energy = OriginEnergyTrack.EnergyProperty;



//        //Once its been added I need to clear the added energy property especially if it is off

//        Overall_Energy += energyTrack.EnergyProperty;

//        Overall_Energy += energyTrack2.EnergyProperty;

//        if (!energyTrack.ActivatedProperty)
//        {
//            energyTrack.EnergyProperty = 0;
//        }

//        if (!energyTrack2.ActivatedProperty)
//        {
//            energyTrack2.EnergyProperty = 0;
//        }

//        OriginEnergyTrack.EnergyProperty = Overall_Energy;

//       // Overall_Energy = PlayerPrefs.GetFloat("Overall_energy");
//        //Overall_Energy += PlayerPrefs.GetFloat("Energy");
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //Check clock

//        //How much energy consumed

//        //While it is not the end of the day keep tracking the energy

//        //if(MainManager.Instance != null)
//        //{
//        //    Overall_Energy += MainManager.Instance.ReturnEnergy();
//        //    MainManager.Instance = null;
//        //    Destroy(            MainManager.Instance);
//        //}

//        if(time_ < 100.0f)
//        {
//            time_ += Time.deltaTime;
//            //Debug.Log(Overall_Energy);
//            string_text = "Overall Energy : " + Overall_Energy.ToString();
//            textelement.text = string_text;
//        }

//        //Overall_Energy += energyTrack.EnergyProperty;

//        //PlayerPrefs.SetFloat("Overall_energy", Overall_Energy);

//        //Loop through each item in enrgy tracker array

//        //switch (energyTrack.ActivatedProperty)
//        //{
//        //    case true:
//        //        //Calculate the additive
//        //        additive += 0.1f * energyTrack.IncreaseProperty;


//        //        //energyTrack.EnergyProperty += 0.1f * energyTrack.IncreaseProperty;


//        //        //Add it to the energy of the room and the overall seperatley

//        //        Overall_Energy += additive;
//        //        energyTrack.EnergyProperty += additive;

//        //        //Overall_Energy = energyTrack.EnergyProperty;


//        //        //OriginEnergyTrack.EnergyProperty = Overall_Energy;
//        //        break;
//        //    case false:
//        //        OriginEnergyTrack.EnergyProperty = Overall_Energy;
//        //        break;
//        //}

//        if(energyTrack.ActivatedProperty == true)
//        {
//            //Calculate the additive
//            additive = 0.1f * energyTrack.IncreaseProperty;
//            //Add it to the energy of the room and the overall seperatley
//            Overall_Energy += additive;
//            energyTrack.EnergyProperty += additive;
//        }

//        if (energyTrack2.ActivatedProperty ==true)
//        {
//            additive = 0.1f * energyTrack2.IncreaseProperty;
//            Overall_Energy += additive;
//            energyTrack2.EnergyProperty += additive;
//        }

//        OriginEnergyTrack.EnergyProperty = Overall_Energy;


//        //Overall_Energy += energyTrack.EnergyProperty;
//        //energyTrack2.EnergyProperty = Overall_Energy;
//    }


//    public void AddEnergy(Component sender, object data)
//    {
//        if (data is float)
//        {
//            float energy = (float)data;
//            Overall_Energy += energy;
//            //Debug.Log("ASASHSAJBSh\n");
//        }
//    }

//    public void SetEnergy(float new_value)
//    {
//        Overall_Energy = new_value;
//    }


//    //public void AddEnergytototal(float new_energy)
//    //{
//    //    Overall_Energy += new_energy;
//    //    if (OnEnergyChanged != null) OnEnergyChanged(null, EventArgs.Empty);
//    //}
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Version 1 for the initial milestone

public class Overhead : MonoBehaviour
{
    //public EventHandler OnEnergyChanged;

    //Replace later with clock function
    private float time_;
    private static float Overall_Energy;
    private string string_text;

    private string string_room1;
    private string string_room2;

    public Text textelement;

    public Text textRoom1;
    public Text textRoom2;

    public static Overhead New_Instance;

    //Need a variable to track the overall amount for each room rather than adding it
    // to the main overall as that is just going to combine their outputs

    //Plan is to keep track of each energy tracker that is attached to a room in an array

    //private float EnergyRoom1;
    //private float EnergyRoom2;
    private float additive;

    [SerializeField]
    private EnergyTracker energyTrack;

    //------------------------------------------
    [SerializeField]
    private EnergyTracker energyTrack2;
    //------------------------------------------

    [SerializeField]
    private EnergyTracker OriginEnergyTrack;
    //[SerializeField]
    //private EnergyTracker energyTrack2;

    //private void Awake()
    //{
    //    if (New_Instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }

    //    New_Instance = this;
    //    DontDestroyOnLoad(gameObject);
    //}

    // Start is called before the first frame update

    [SerializeField]
    CurrentRoom this_room;

    [SerializeField]
    public int RoomNum;

    private void Awake()
    {
        Overall_Energy = 0;
    }

    public void SetupEnergy()
    {
        Overall_Energy = 0;
    }

    public void Startup()
    {
        time_ = 0;
        //Overall_Energy =0;
        string_text = "Default";

        //EnergyRoom1 = energyTrack.EnergyProperty;
        //EnergyRoom2 = energyTrack2.EnergyProperty;
        additive = 0;

        Overall_Energy = OriginEnergyTrack.EnergyProperty;



        //Once its been added I need to clear the added energy property especially if it is off

        //Overall_Energy += energyTrack.EnergyProperty;
        Overall_Energy += energyTrack.Energy_to_be_added_property;

        //------------------------------------------
        //Overall_Energy += energyTrack2.EnergyProperty;
        Overall_Energy += energyTrack2.Energy_to_be_added_property;
        //------------------------------------------

        if (!energyTrack.ActivatedProperty)
        {
            energyTrack.EnergyProperty = 0;
        }

        //------------------------------------------
        if (!energyTrack2.ActivatedProperty)
        {
            energyTrack2.EnergyProperty = 0;
        }
        //------------------------------------------

        //OriginEnergyTrack.EnergyProperty = Overall_Energy;

        // Overall_Energy = PlayerPrefs.GetFloat("Overall_energy");
        //Overall_Energy += PlayerPrefs.GetFloat("Energy");
    }

    //void Start()
    //{
    //    time_ = 0;
    //    //Overall_Energy =0;
    //    string_text = "Default";

    //    //EnergyRoom1 = energyTrack.EnergyProperty;
    //    //EnergyRoom2 = energyTrack2.EnergyProperty;
    //    additive = 0;

    //    Overall_Energy = OriginEnergyTrack.EnergyProperty;



    //    //Once its been added I need to clear the added energy property especially if it is off

    //    //Overall_Energy += energyTrack.EnergyProperty;
    //    Overall_Energy += energyTrack.Energy_to_be_added_property;

    //    //------------------------------------------
    //    //Overall_Energy += energyTrack2.EnergyProperty;
    //    Overall_Energy += energyTrack2.Energy_to_be_added_property;
    //    //------------------------------------------

    //    if (!energyTrack.ActivatedProperty)
    //    {
    //        energyTrack.EnergyProperty = 0;
    //    }

    //    //------------------------------------------
    //    if (!energyTrack2.ActivatedProperty)
    //    {
    //        energyTrack2.EnergyProperty = 0;
    //    }
    //    //------------------------------------------

    //    //OriginEnergyTrack.EnergyProperty = Overall_Energy;

    //    // Overall_Energy = PlayerPrefs.GetFloat("Overall_energy");
    //    //Overall_Energy += PlayerPrefs.GetFloat("Energy");
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    //Check clock

    //    //How much energy consumed

    //    //While it is not the end of the day keep tracking the energy

    //    //if(MainManager.Instance != null)
    //    //{
    //    //    Overall_Energy += MainManager.Instance.ReturnEnergy();
    //    //    MainManager.Instance = null;
    //    //    Destroy(            MainManager.Instance);
    //    //}

    //    if (time_ < 100.0f)
    //    {
    //        time_ += Time.deltaTime;
    //        //Debug.Log(Overall_Energy);
    //        string_text = Overall_Energy.ToString();
    //        textelement.text = string_text;

    //        string_room1 = energyTrack.EnergyProperty.ToString();
    //        textRoom1.text = string_room1;

    //        string_room2 = energyTrack2.EnergyProperty.ToString();
    //        textRoom2.text = string_room2;
    //    }

    //    //Overall_Energy += energyTrack.EnergyProperty;

    //    //PlayerPrefs.SetFloat("Overall_energy", Overall_Energy);

    //    //Loop through each item in enrgy tracker array

    //    //switch (energyTrack.ActivatedProperty)
    //    //{
    //    //    case true:
    //    //        //Calculate the additive
    //    //        additive += 0.1f * energyTrack.IncreaseProperty;


    //    //        //energyTrack.EnergyProperty += 0.1f * energyTrack.IncreaseProperty;


    //    //        //Add it to the energy of the room and the overall seperatley

    //    //        Overall_Energy += additive;
    //    //        energyTrack.EnergyProperty += additive;

    //    //        //Overall_Energy = energyTrack.EnergyProperty;


    //    //        //OriginEnergyTrack.EnergyProperty = Overall_Energy;
    //    //        break;
    //    //    case false:
    //    //        OriginEnergyTrack.EnergyProperty = Overall_Energy;
    //    //        break;
    //    //}

    //    if (energyTrack.ActivatedProperty == true)
    //    {
    //        //Calculate the additive
    //        additive = (0.001f * energyTrack.IncreaseProperty) * Time.deltaTime;
    //        //Add it to the energy of the room and the overall seperatley
    //        Overall_Energy += additive;
    //        energyTrack.EnergyProperty += additive;
    //    }
    //    else
    //    {
    //        additive = 0.0f;
    //    }

    //    //------------------------------------------
    //    if (energyTrack2.ActivatedProperty == true)
    //    {
    //        //Calculate the additive

    //        //Increase property has defaulted to zero for some reason
    //        additive = (0.001f * energyTrack2.IncreaseProperty) * Time.deltaTime;

    //        //Add it to the energy of the room and the overall seperatley
    //        Overall_Energy += additive;
    //        energyTrack2.EnergyProperty += additive;
    //    }
    //    else
    //    {
    //        additive = 0.0f;
    //    }
    //    //------------------------------------------

    //    //if (energyTrack2.ActivatedProperty == true)
    //    //{
    //    //    additive = 0.1f * energyTrack2.IncreaseProperty;
    //    //    Overall_Energy += additive;
    //    //    energyTrack2.EnergyProperty += additive;
    //    //}

    //    OriginEnergyTrack.EnergyProperty = Overall_Energy;


    //    //Overall_Energy += energyTrack.EnergyProperty;
    //    //energyTrack2.EnergyProperty = Overall_Energy;
    //}

    ////Update to be run in stable with the one room
    //void Update()
    //{
    //    if(this_room.GetRoom() == RoomNum)
    //    {
    //        RunRoom();
    //    }
    //}

    void RunRoom()
    {
        //Check clock

        //How much energy consumed

        //While it is not the end of the day keep tracking the energy

        //if(MainManager.Instance != null)
        //{
        //    Overall_Energy += MainManager.Instance.ReturnEnergy();
        //    MainManager.Instance = null;
        //    Destroy(            MainManager.Instance);
        //}

        if (time_ < 100.0f)
        {
            time_ += Time.deltaTime;
            //Debug.Log(Overall_Energy);
            string_text = Overall_Energy.ToString();
            textelement.text = string_text;

            string_room1 = energyTrack.EnergyProperty.ToString();
            textRoom1.text = string_room1;

            string_room2 = energyTrack2.EnergyProperty.ToString();
            textRoom2.text = string_room2;
        }

        //Overall_Energy += energyTrack.EnergyProperty;

        //PlayerPrefs.SetFloat("Overall_energy", Overall_Energy);

        //Loop through each item in enrgy tracker array

        //switch (energyTrack.ActivatedProperty)
        //{
        //    case true:
        //        //Calculate the additive
        //        additive += 0.1f * energyTrack.IncreaseProperty;


        //        //energyTrack.EnergyProperty += 0.1f * energyTrack.IncreaseProperty;


        //        //Add it to the energy of the room and the overall seperatley

        //        Overall_Energy += additive;
        //        energyTrack.EnergyProperty += additive;

        //        //Overall_Energy = energyTrack.EnergyProperty;


        //        //OriginEnergyTrack.EnergyProperty = Overall_Energy;
        //        break;
        //    case false:
        //        OriginEnergyTrack.EnergyProperty = Overall_Energy;
        //        break;
        //}

        if (energyTrack.ActivatedProperty == true)
        {
            //Calculate the additive
            additive = (0.1f * energyTrack.IncreaseProperty) * Time.deltaTime;
            //Add it to the energy of the room and the overall seperatley
            Overall_Energy += additive;
            energyTrack.EnergyProperty += additive;
        }
        else
        {
            additive = 0.0f;
        }

        //------------------------------------------
        if (energyTrack2.ActivatedProperty == true)
        {
            //Calculate the additive

            //Increase property has defaulted to zero for some reason
            additive = (0.1f * energyTrack2.IncreaseProperty) * Time.deltaTime;

            //Add it to the energy of the room and the overall seperatley
            Overall_Energy += additive;
            energyTrack2.EnergyProperty += additive;
        }
        else
        {
            additive = 0.0f;
        }
        //------------------------------------------

        if (!energyTrack.ActivatedProperty)
        {
            energyTrack.EnergyProperty = 0;
        }

        //------------------------------------------
        if (!energyTrack2.ActivatedProperty)
        {
            energyTrack2.EnergyProperty = 0;
        }

        //if (energyTrack2.ActivatedProperty == true)
        //{
        //    additive = 0.1f * energyTrack2.IncreaseProperty;
        //    Overall_Energy += additive;
        //    energyTrack2.EnergyProperty += additive;
        //}

        OriginEnergyTrack.EnergyProperty = Overall_Energy;


        //Overall_Energy += energyTrack.EnergyProperty;
        //energyTrack2.EnergyProperty = Overall_Energy;
    }


    public void AddEnergy(Component sender, object data)
    {
        //Doesnt like me doing this it does work however
        if (RoomNum == sender.GetComponent<LeverInteraction>().Room_num)
        {
            if (data is float)
            {
                float energy = (float)data;
                Overall_Energy += energy;
                //Debug.Log("ASASHSAJBSh\n");
            }
        }
    }

    void Update()
    {
        //if (this_room.GetRoom() == RoomNum)
        //{
            RunRoom();
        //}
    }

    //public void SetEnergy(float new_value)
    //{
    //    Overall_Energy = new_value;
    //}


    //public void AddEnergytototal(float new_energy)
    //{
    //    Overall_Energy += new_energy;
    //    if (OnEnergyChanged != null) OnEnergyChanged(null, EventArgs.Empty);
    //}
}