////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;

////public class OverHeadManager : MonoBehaviour
////{
////    //static private OverHeadManager Instance = null;
////    public Overhead overhead_;
////    public EnergyTracker energyTrack;
////    public EnergyTracker energyTrack2;
////    public EnergyTracker energyTrack3;

////    public static float energyTrack_amount;
////    public static float energyTrack2_amount;
////    public static float energyTrack3_amount;


////    public float new_energyTrack_amount;
////    public float new_energyTrack2_amount;
////    public float new_energyTrack3_amount;

////    private static bool firstPlay=true;


////    void Awake()
////    {
////        //if(Instance!=null)
////        //{
////        //    Destroy(this);
////        //    return;
////        //}
////        //else if (Instance == null)
////        //{
////        //    Instance = this;

////        //    //PlayerPrefs.DeleteAll();

////        //    overhead_.SetEnergy(0);
////        //    PlayerPrefs.SetFloat("Overall_energy", 0);
////        //    PlayerPrefs.SetFloat("Energy", 0);
////        //    energyTrack.EnergyProperty = 0;
////        //    energyTrack2.EnergyProperty = 0;

////        //    //DontDestroyOnLoad(Instance);
////        //}

////        //if(firstPlay != false)
////        //{
////        //    PlayerPrefs.SetInt("FirstPlay", 1);
////        //}

////        //if(PlayerPrefs.GetInt("Firstplay")== 1)
////        //{
////        //    //runNow = false;
////        //    PlayerPrefs.SetInt("FirstPlay", 0);
////        //    PlayerPrefs.Save();
////        //    Debug.Log("Starting...\n");
////        //    firstPlay = true;
////        //}
////        //else
////        //{
////        //    //runNow = true;
////        //    Debug.Log("Running...\n");
////        //    firstPlay = false;
////        //}

////        if(firstPlay == true)
////        {
////            Debug.Log("Starting...\n");
////            //PlayerPrefs.DeleteAll();

////            overhead_.SetEnergy(0);
////            //PlayerPrefs.SetFloat("Overall_energy", 0);
////            //PlayerPrefs.SetFloat("Energy", 0);

////            energyTrack.EnergyProperty = 0;
////            energyTrack2.EnergyProperty = 0;
////            energyTrack3.EnergyProperty = 0;
////            energyTrack.IncreaseProperty = 1;
////            energyTrack2.IncreaseProperty = 1;
////            energyTrack3.IncreaseProperty = 1;
////            energyTrack.ActivatedProperty = false;
////            energyTrack2.ActivatedProperty = false;
////            energyTrack3.ActivatedProperty = false;

////            energyTrack_amount = 0.0f;
////            energyTrack2_amount = 0.0f;
////            energyTrack3_amount = 0.0f;

////            firstPlay = false;
////        }
////        else
////        {
////            Debug.Log("Running...\n");

////            if (!energyTrack.ActivatedProperty)
////            {
////                if (energyTrack.EnergyProperty > energyTrack_amount)
////                {
////                    Debug.Log(energyTrack.EnergyProperty);
////                    //Not doing anything
////                    new_energyTrack_amount = energyTrack.EnergyProperty - energyTrack_amount;
////                    energyTrack.EnergyProperty = new_energyTrack_amount;
////                    Debug.Log(energyTrack.EnergyProperty);
////                }
////            }

////            //if (!energyTrack2.ActivatedProperty)
////            //{
////            //    if (energyTrack2.EnergyProperty > energyTrack2_amount)
////            //    {
////            //        new_energyTrack2_amount = energyTrack2.EnergyProperty - energyTrack2_amount;
////            //        energyTrack2.EnergyProperty = new_energyTrack2_amount;
////            //    }
////            //}

////            if (!energyTrack3.ActivatedProperty)
////            {

////                if (energyTrack3.EnergyProperty > energyTrack3_amount)
////                {
////                    new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
////                    energyTrack3.EnergyProperty = new_energyTrack3_amount;
////                }
////            }
////        }
////    }

////    private void OnDestroy()
////    {
////        energyTrack_amount = energyTrack.EnergyProperty;
////        //energyTrack2_amount = energyTrack2.EnergyProperty;
////        energyTrack3_amount = energyTrack3.EnergyProperty;
////    }
////}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OverHeadManager : MonoBehaviour
//{
//    //static private OverHeadManager Instance = null;
//    public Overhead overhead_;
//    [SerializeField]
//    public EnergyTracker energyTrack;
//    [SerializeField]
//    public EnergyTracker energyTrack2;
//    //------------------------------------------
//    [SerializeField]
//    public EnergyTracker energyTrack3;
//    //------------------------------------------

//    [SerializeField]
//    public SliderState slide_state;
//    public bool now_state;

//    public static float energyTrack_amount;
//    public static float energyTrack2_amount;
//    //------------------------------------------
//    public static float energyTrack3_amount;
//    //------------------------------------------


//    public float new_energyTrack_amount;
//    public float new_energyTrack2_amount;
//    //------------------------------------------
//    public float new_energyTrack3_amount;
//    //------------------------------------------

//    private static bool firstPlay = true;

//    private void OnEnable()
//    {
//        //if(energyTrack3.ActivatedProperty == false)
//        //{
//        //    int n = 0;
//        //}

//        //if (energyTrack3.ActivatedProperty == true)
//        //{
//        //    int k = 0;
//        //}
//    }


//    void Awake()
//    {
//        //This changes on re-open before anything else
//        //if (energyTrack3.ActivatedProperty == false)
//        //{
//        //    int j = 0;
//        //}

//        //if(Instance!=null)
//        //{
//        //    Destroy(this);
//        //    return;
//        //}
//        //else if (Instance == null)
//        //{
//        //    Instance = this;

//        //    //PlayerPrefs.DeleteAll();

//        //    overhead_.SetEnergy(0);
//        //    PlayerPrefs.SetFloat("Overall_energy", 0);
//        //    PlayerPrefs.SetFloat("Energy", 0);
//        //    energyTrack.EnergyProperty = 0;
//        //    energyTrack2.EnergyProperty = 0;

//        //    //DontDestroyOnLoad(Instance);
//        //}

//        //if(firstPlay != false)
//        //{
//        //    PlayerPrefs.SetInt("FirstPlay", 1);
//        //}

//        //if(PlayerPrefs.GetInt("Firstplay")== 1)
//        //{
//        //    //runNow = false;
//        //    PlayerPrefs.SetInt("FirstPlay", 0);
//        //    PlayerPrefs.Save();
//        //    Debug.Log("Starting...\n");
//        //    firstPlay = true;
//        //}
//        //else
//        //{
//        //    //runNow = true;
//        //    Debug.Log("Running...\n");
//        //    firstPlay = false;
//        //}

//        if (firstPlay == true)
//        {
//            Debug.Log("Starting...\n");
//            //PlayerPrefs.DeleteAll();

//            //overhead_.SetEnergy(0);
//            //PlayerPrefs.SetFloat("Overall_energy", 0);
//            //PlayerPrefs.SetFloat("Energy", 0);

//            energyTrack.EnergyProperty = 0;
//            energyTrack2.EnergyProperty = 0;

//            //------------------------------------------
//            energyTrack3.EnergyProperty = 0;
//            //------------------------------------------

//            energyTrack.IncreaseProperty = 1;
//            energyTrack2.IncreaseProperty = 1;

//            //------------------------------------------
//            energyTrack3.IncreaseProperty = 1;
//            //------------------------------------------

//            energyTrack.ActivatedProperty = false;
//            energyTrack2.ActivatedProperty = false;

//            //------------------------------------------
//            energyTrack3.ActivatedProperty = false;
//            //------------------------------------------

//            energyTrack_amount = 0.0f;
//            new_energyTrack_amount = 0.0f;
//            //------------------------------------------
//            new_energyTrack3_amount = 0.0f;
//            //------------------------------------------
//            //energyTrack2_amount = 0.0f;
//            //------------------------------------------
//            energyTrack3_amount = 0.0f;
//            //------------------------------------------

//            energyTrack.My_firstPlay = true;
//            energyTrack3.My_firstPlay = true;

//            energyTrack.Energy_to_be_added_property = 0.0f;
//            energyTrack3.Energy_to_be_added_property = 0.0f;


//            slide_state.StateProperty = false;

//            firstPlay = false;

//            //Screen.SetResolution(1920, 1080, true, 60);


//            energyTrack.My_ActiveOnEntryAndExit = false;
//            energyTrack3.My_ActiveOnEntryAndExit = false;


//            energyTrack.MyRoomNum = 1;
//            energyTrack3.MyRoomNum = 2;
//            energyTrack2.MyRoomNum = 0;


//            energyTrack.OtherRoomProperty = false;
//            energyTrack2.OtherRoomProperty = false;
//            energyTrack3.OtherRoomProperty = false;

//        }
//        else
//        {
//            Debug.Log("Running...\n");

//            now_state = slide_state.StateProperty;
//            energyTrack2.EnergyProperty = energyTrack2_amount;
//            //int i;
//            //Gets set to zero
//            //i = energyTrack3.IncreaseProperty;




//            if (energyTrack.ActivatedProperty == false || energyTrack.My_ActiveOnEntryAndExit == true || energyTrack.OtherRoomProperty == true)
//            {
//                if (energyTrack.EnergyProperty > energyTrack_amount)
//                {
//                    //Debug.Log(energyTrack.EnergyProperty);
//                    //Not doing anything
//                    new_energyTrack_amount = energyTrack.EnergyProperty - energyTrack_amount;
//                    energyTrack.Energy_to_be_added_property = new_energyTrack_amount;

//                    if (energyTrack.ActivatedProperty == false && energyTrack.My_ActiveOnEntryAndExit == false)
//                    {
//                        energyTrack.EnergyProperty = energyTrack.Energy_to_be_added_property;
//                    }

//                    if(energyTrack.OtherRoomProperty == true)
//                    {
//                        energyTrack.OtherRoomProperty = false;
//                    }
//                    //new_energyTrack_amount = 0.0f;
//                    //Debug.Log(energyTrack.EnergyProperty);
//                }
//            }
//            else
//            {
//                energyTrack_amount = 0.0f;
//                new_energyTrack_amount = 0.0f;
//                energyTrack.Energy_to_be_added_property = energyTrack.EnergyProperty;
//                energyTrack.My_ActiveOnEntryAndExit = false;
//            }

//            //------------------------------------------

//            //This tracker is getting reset, why?

//            if (energyTrack3.ActivatedProperty == false || energyTrack3.My_ActiveOnEntryAndExit == true || energyTrack3.OtherRoomProperty == true)
//            {
//                if (energyTrack3.EnergyProperty > energyTrack3_amount)
//                {
//                    //Debug.Log(energyTrack.EnergyProperty);
//                    //Not doing anything
//                    new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
//                    energyTrack3.Energy_to_be_added_property = new_energyTrack3_amount;

//                    if (energyTrack.ActivatedProperty == false && energyTrack3.My_ActiveOnEntryAndExit == false)
//                    {
//                        energyTrack3.EnergyProperty = energyTrack3.Energy_to_be_added_property;
//                    }
//                    //new_energyTrack_amount = 0.0f;
//                    //Debug.Log(energyTrack.EnergyProperty);

//                    if (energyTrack3.OtherRoomProperty == true)
//                    {
//                        energyTrack3.OtherRoomProperty = false;
//                    }
//                }
//            }
//            else
//            {
//                energyTrack3_amount = 0.0f;
//                new_energyTrack3_amount = 0.0f;
//                energyTrack3.Energy_to_be_added_property = energyTrack3.EnergyProperty;
//                energyTrack3.My_ActiveOnEntryAndExit = false;
//            }

//            //if(energyTrack3.ActivatedProperty)
//            //{
//            //    int k = 0;
//            //}

//            //------------------------------------------

//            //if (!energyTrack2.ActivatedProperty)
//            //{
//            //    if (energyTrack2.EnergyProperty > energyTrack2_amount)
//            //    {
//            //        new_energyTrack2_amount = energyTrack2.EnergyProperty - energyTrack2_amount;
//            //        energyTrack2.EnergyProperty = new_energyTrack2_amount;
//            //    }
//            //}

//            //if (!energyTrack3.ActivatedProperty)
//            //{

//            //    if (energyTrack3.EnergyProperty > energyTrack3_amount)
//            //    {
//            //        new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
//            //        energyTrack3.EnergyProperty = new_energyTrack3_amount;
//            //    }
//            //}
//        }
//    }

//    private void OnDestroy()
//    {
//        energyTrack_amount = energyTrack.EnergyProperty;
//        energyTrack2_amount = energyTrack2.EnergyProperty;
//        slide_state.StateProperty = now_state;
//        //------------------------------------------
//        energyTrack3_amount = energyTrack3.EnergyProperty;
//        //------------------------------------------

//        energyTrack.Energy_to_be_added_property = 0;
//        energyTrack3.Energy_to_be_added_property = 0;

//        //energyTrack2_amount = energyTrack2.EnergyProperty;
//        //energyTrack3_amount = energyTrack3.EnergyProperty;
//    }




//    public void RunSetup()
//    {
//        //This changes on re-open before anything else
//        //if (energyTrack3.ActivatedProperty == false)
//        //{
//        //    int j = 0;
//        //}

//        //if(Instance!=null)
//        //{
//        //    Destroy(this);
//        //    return;
//        //}
//        //else if (Instance == null)
//        //{
//        //    Instance = this;

//        //    //PlayerPrefs.DeleteAll();

//        //    overhead_.SetEnergy(0);
//        //    PlayerPrefs.SetFloat("Overall_energy", 0);
//        //    PlayerPrefs.SetFloat("Energy", 0);
//        //    energyTrack.EnergyProperty = 0;
//        //    energyTrack2.EnergyProperty = 0;

//        //    //DontDestroyOnLoad(Instance);
//        //}

//        //if(firstPlay != false)
//        //{
//        //    PlayerPrefs.SetInt("FirstPlay", 1);
//        //}

//        //if(PlayerPrefs.GetInt("Firstplay")== 1)
//        //{
//        //    //runNow = false;
//        //    PlayerPrefs.SetInt("FirstPlay", 0);
//        //    PlayerPrefs.Save();
//        //    Debug.Log("Starting...\n");
//        //    firstPlay = true;
//        //}
//        //else
//        //{
//        //    //runNow = true;
//        //    Debug.Log("Running...\n");
//        //    firstPlay = false;
//        //}

//        if (firstPlay == true)
//        {
//            Debug.Log("Starting...\n");
//            //PlayerPrefs.DeleteAll();

//            //overhead_.SetEnergy(0);
//            //PlayerPrefs.SetFloat("Overall_energy", 0);
//            //PlayerPrefs.SetFloat("Energy", 0);

//            energyTrack.EnergyProperty = 0;
//            energyTrack2.EnergyProperty = 0;

//            //------------------------------------------
//            energyTrack3.EnergyProperty = 0;
//            //------------------------------------------

//            energyTrack.IncreaseProperty = 1;
//            energyTrack2.IncreaseProperty = 1;

//            //------------------------------------------
//            energyTrack3.IncreaseProperty = 1;
//            //------------------------------------------

//            energyTrack.ActivatedProperty = false;
//            energyTrack2.ActivatedProperty = false;

//            //------------------------------------------
//            energyTrack3.ActivatedProperty = false;
//            //------------------------------------------

//            energyTrack_amount = 0.0f;
//            new_energyTrack_amount = 0.0f;
//            //------------------------------------------
//            new_energyTrack3_amount = 0.0f;
//            //------------------------------------------
//            //energyTrack2_amount = 0.0f;
//            //------------------------------------------
//            energyTrack3_amount = 0.0f;
//            //------------------------------------------

//            energyTrack.My_firstPlay = true;
//            energyTrack3.My_firstPlay = true;

//            energyTrack.Energy_to_be_added_property = 0.0f;
//            energyTrack3.Energy_to_be_added_property = 0.0f;


//            slide_state.StateProperty = false;

//            firstPlay = false;

//            //Screen.SetResolution(1920, 1080, true, 60);


//            energyTrack.My_ActiveOnEntryAndExit = false;
//            energyTrack3.My_ActiveOnEntryAndExit = false;


//            energyTrack.MyRoomNum = 1;
//            energyTrack3.MyRoomNum = 2;
//            energyTrack2.MyRoomNum = 0;


//            energyTrack.OtherRoomProperty = false;
//            energyTrack2.OtherRoomProperty = false;
//            energyTrack3.OtherRoomProperty = false;


//            overhead_.SetupEnergy();
//        }
//        else
//        {
//            Debug.Log("Running...\n");

//            now_state = slide_state.StateProperty;
//            energyTrack2.EnergyProperty = energyTrack2_amount;
//            //int i;
//            //Gets set to zero
//            //i = energyTrack3.IncreaseProperty;


//            overhead_.SetupEnergy();

//            if (energyTrack.ActivatedProperty == false || energyTrack.My_ActiveOnEntryAndExit == true || energyTrack.OtherRoomProperty == true)
//            {
//                if (energyTrack.EnergyProperty > energyTrack_amount)
//                {
//                    //Debug.Log(energyTrack.EnergyProperty);
//                    //Not doing anything
//                    new_energyTrack_amount = energyTrack.EnergyProperty - energyTrack_amount;
//                    energyTrack.Energy_to_be_added_property = new_energyTrack_amount;

//                    if (energyTrack.ActivatedProperty == false && energyTrack.My_ActiveOnEntryAndExit == false)
//                    {
//                        energyTrack.EnergyProperty = energyTrack.Energy_to_be_added_property;
//                    }

//                    if (energyTrack.OtherRoomProperty == true)
//                    {
//                        energyTrack.OtherRoomProperty = false;
//                    }
//                    //new_energyTrack_amount = 0.0f;
//                    //Debug.Log(energyTrack.EnergyProperty);
//                }
//            }
//            else
//            {
//                energyTrack_amount = 0.0f;
//                new_energyTrack_amount = 0.0f;
//                energyTrack.Energy_to_be_added_property = energyTrack.EnergyProperty;
//                energyTrack.My_ActiveOnEntryAndExit = false;
//            }

//            //------------------------------------------

//            //This tracker is getting reset, why?

//            if (energyTrack3.ActivatedProperty == false || energyTrack3.My_ActiveOnEntryAndExit == true || energyTrack3.OtherRoomProperty == true)
//            {
//                if (energyTrack3.EnergyProperty > energyTrack3_amount)
//                {
//                    //Debug.Log(energyTrack.EnergyProperty);
//                    //Not doing anything
//                    new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
//                    energyTrack3.Energy_to_be_added_property = new_energyTrack3_amount;

//                    if (energyTrack.ActivatedProperty == false && energyTrack3.My_ActiveOnEntryAndExit == false)
//                    {
//                        energyTrack3.EnergyProperty = energyTrack3.Energy_to_be_added_property;
//                    }
//                    //new_energyTrack_amount = 0.0f;
//                    //Debug.Log(energyTrack.EnergyProperty);

//                    if (energyTrack3.OtherRoomProperty == true)
//                    {
//                        energyTrack3.OtherRoomProperty = false;
//                    }
//                }
//            }
//            else
//            {
//                energyTrack3_amount = 0.0f;
//                new_energyTrack3_amount = 0.0f;
//                energyTrack3.Energy_to_be_added_property = energyTrack3.EnergyProperty;
//                energyTrack3.My_ActiveOnEntryAndExit = false;
//            }

//            //if(energyTrack3.ActivatedProperty)
//            //{
//            //    int k = 0;
//            //}

//            //------------------------------------------

//            //if (!energyTrack2.ActivatedProperty)
//            //{
//            //    if (energyTrack2.EnergyProperty > energyTrack2_amount)
//            //    {
//            //        new_energyTrack2_amount = energyTrack2.EnergyProperty - energyTrack2_amount;
//            //        energyTrack2.EnergyProperty = new_energyTrack2_amount;
//            //    }
//            //}

//            //if (!energyTrack3.ActivatedProperty)
//            //{

//            //    if (energyTrack3.EnergyProperty > energyTrack3_amount)
//            //    {
//            //        new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
//            //        energyTrack3.EnergyProperty = new_energyTrack3_amount;
//            //    }
//            //}
//        }
//    }

//    public void On_Close()
//    {
//        energyTrack_amount = energyTrack.EnergyProperty;
//        energyTrack2_amount = energyTrack2.EnergyProperty;
//        slide_state.StateProperty = now_state;
//        //------------------------------------------
//        energyTrack3_amount = energyTrack3.EnergyProperty;
//        //------------------------------------------

//        energyTrack.Energy_to_be_added_property = 0;
//        energyTrack3.Energy_to_be_added_property = 0;

//        //energyTrack2_amount = energyTrack2.EnergyProperty;
//        //energyTrack3_amount = energyTrack3.EnergyProperty;
//    }
//}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OverHeadManager : MonoBehaviour
//{
//    //static private OverHeadManager Instance = null;
//    public Overhead overhead_;
//    public EnergyTracker energyTrack;
//    public EnergyTracker energyTrack2;
//    public EnergyTracker energyTrack3;

//    public static float energyTrack_amount;
//    public static float energyTrack2_amount;
//    public static float energyTrack3_amount;


//    public float new_energyTrack_amount;
//    public float new_energyTrack2_amount;
//    public float new_energyTrack3_amount;

//    private static bool firstPlay=true;


//    void Awake()
//    {
//        //if(Instance!=null)
//        //{
//        //    Destroy(this);
//        //    return;
//        //}
//        //else if (Instance == null)
//        //{
//        //    Instance = this;

//        //    //PlayerPrefs.DeleteAll();

//        //    overhead_.SetEnergy(0);
//        //    PlayerPrefs.SetFloat("Overall_energy", 0);
//        //    PlayerPrefs.SetFloat("Energy", 0);
//        //    energyTrack.EnergyProperty = 0;
//        //    energyTrack2.EnergyProperty = 0;

//        //    //DontDestroyOnLoad(Instance);
//        //}

//        //if(firstPlay != false)
//        //{
//        //    PlayerPrefs.SetInt("FirstPlay", 1);
//        //}

//        //if(PlayerPrefs.GetInt("Firstplay")== 1)
//        //{
//        //    //runNow = false;
//        //    PlayerPrefs.SetInt("FirstPlay", 0);
//        //    PlayerPrefs.Save();
//        //    Debug.Log("Starting...\n");
//        //    firstPlay = true;
//        //}
//        //else
//        //{
//        //    //runNow = true;
//        //    Debug.Log("Running...\n");
//        //    firstPlay = false;
//        //}

//        if(firstPlay == true)
//        {
//            Debug.Log("Starting...\n");
//            //PlayerPrefs.DeleteAll();

//            overhead_.SetEnergy(0);
//            //PlayerPrefs.SetFloat("Overall_energy", 0);
//            //PlayerPrefs.SetFloat("Energy", 0);

//            energyTrack.EnergyProperty = 0;
//            energyTrack2.EnergyProperty = 0;
//            energyTrack3.EnergyProperty = 0;
//            energyTrack.IncreaseProperty = 1;
//            energyTrack2.IncreaseProperty = 1;
//            energyTrack3.IncreaseProperty = 1;
//            energyTrack.ActivatedProperty = false;
//            energyTrack2.ActivatedProperty = false;
//            energyTrack3.ActivatedProperty = false;

//            energyTrack_amount = 0.0f;
//            energyTrack2_amount = 0.0f;
//            energyTrack3_amount = 0.0f;

//            firstPlay = false;
//        }
//        else
//        {
//            Debug.Log("Running...\n");

//            if (!energyTrack.ActivatedProperty)
//            {
//                if (energyTrack.EnergyProperty > energyTrack_amount)
//                {
//                    Debug.Log(energyTrack.EnergyProperty);
//                    //Not doing anything
//                    new_energyTrack_amount = energyTrack.EnergyProperty - energyTrack_amount;
//                    energyTrack.EnergyProperty = new_energyTrack_amount;
//                    Debug.Log(energyTrack.EnergyProperty);
//                }
//            }

//            //if (!energyTrack2.ActivatedProperty)
//            //{
//            //    if (energyTrack2.EnergyProperty > energyTrack2_amount)
//            //    {
//            //        new_energyTrack2_amount = energyTrack2.EnergyProperty - energyTrack2_amount;
//            //        energyTrack2.EnergyProperty = new_energyTrack2_amount;
//            //    }
//            //}

//            if (!energyTrack3.ActivatedProperty)
//            {

//                if (energyTrack3.EnergyProperty > energyTrack3_amount)
//                {
//                    new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
//                    energyTrack3.EnergyProperty = new_energyTrack3_amount;
//                }
//            }
//        }
//    }

//    private void OnDestroy()
//    {
//        energyTrack_amount = energyTrack.EnergyProperty;
//        //energyTrack2_amount = energyTrack2.EnergyProperty;
//        energyTrack3_amount = energyTrack3.EnergyProperty;
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverHeadManager : MonoBehaviour
{
    //static private OverHeadManager Instance = null;
    public Overhead overhead_;
    [SerializeField]
    public EnergyTracker energyTrack;
    [SerializeField]
    public EnergyTracker energyTrack2;
    //------------------------------------------
    [SerializeField]
    public EnergyTracker energyTrack3;
    //------------------------------------------

    [SerializeField]
    public SliderState slide_state;
    public bool now_state;

    public static float energyTrack_amount;
    public static float energyTrack2_amount;
    //------------------------------------------
    public static float energyTrack3_amount;
    //------------------------------------------


    public float new_energyTrack_amount;
    public float new_energyTrack2_amount;
    //------------------------------------------
    public float new_energyTrack3_amount;
    //------------------------------------------

    private static bool firstPlay = true;

    private int RoomNum;

    private void OnEnable()
    {
        //if(energyTrack3.ActivatedProperty == false)
        //{
        //    int n = 0;
        //}

        //if (energyTrack3.ActivatedProperty == true)
        //{
        //    int k = 0;
        //}
    }

    //This can go whereever the new startup is
    private void Start()
    {
        RoomNum = overhead_.RoomNum;
    }


    void Awake()
    {
        //This changes on re-open before anything else
        //if (energyTrack3.ActivatedProperty == false)
        //{
        //    int j = 0;
        //}

        //if(Instance!=null)
        //{
        //    Destroy(this);
        //    return;
        //}
        //else if (Instance == null)
        //{
        //    Instance = this;

        //    //PlayerPrefs.DeleteAll();

        //    overhead_.SetEnergy(0);
        //    PlayerPrefs.SetFloat("Overall_energy", 0);
        //    PlayerPrefs.SetFloat("Energy", 0);
        //    energyTrack.EnergyProperty = 0;
        //    energyTrack2.EnergyProperty = 0;

        //    //DontDestroyOnLoad(Instance);
        //}

        //if(firstPlay != false)
        //{
        //    PlayerPrefs.SetInt("FirstPlay", 1);
        //}

        //if(PlayerPrefs.GetInt("Firstplay")== 1)
        //{
        //    //runNow = false;
        //    PlayerPrefs.SetInt("FirstPlay", 0);
        //    PlayerPrefs.Save();
        //    Debug.Log("Starting...\n");
        //    firstPlay = true;
        //}
        //else
        //{
        //    //runNow = true;
        //    Debug.Log("Running...\n");
        //    firstPlay = false;
        //}

        if (firstPlay == true)
        {
            Debug.Log("Starting...\n");
            //PlayerPrefs.DeleteAll();

            //overhead_.SetEnergy(0);
            //PlayerPrefs.SetFloat("Overall_energy", 0);
            //PlayerPrefs.SetFloat("Energy", 0);

            energyTrack.EnergyProperty = 0;
            energyTrack2.EnergyProperty = 0;

            //------------------------------------------
            energyTrack3.EnergyProperty = 0;
            //------------------------------------------

            energyTrack.IncreaseProperty = 1;
            energyTrack2.IncreaseProperty = 1;

            //------------------------------------------
            energyTrack3.IncreaseProperty = 1;
            //------------------------------------------

            energyTrack.ActivatedProperty = false;
            energyTrack2.ActivatedProperty = false;

            //------------------------------------------
            energyTrack3.ActivatedProperty = false;
            //------------------------------------------

            energyTrack_amount = 0.0f;
            new_energyTrack_amount = 0.0f;
            //------------------------------------------
            new_energyTrack3_amount = 0.0f;
            //------------------------------------------
            //energyTrack2_amount = 0.0f;
            //------------------------------------------
            energyTrack3_amount = 0.0f;
            //------------------------------------------

            energyTrack.My_firstPlay = true;
            energyTrack3.My_firstPlay = true;

            energyTrack.Energy_to_be_added_property = 0.0f;
            energyTrack3.Energy_to_be_added_property = 0.0f;


            slide_state.StateProperty = false;

            firstPlay = false;

            //Screen.SetResolution(1920, 1080, true, 60);


            energyTrack.My_ActiveOnEntryAndExit = false;
            energyTrack3.My_ActiveOnEntryAndExit = false;


            energyTrack.MyRoomNum = 1;
            energyTrack3.MyRoomNum = 2;
            energyTrack2.MyRoomNum = 0;


            energyTrack.OtherRoomProperty = false;
            energyTrack2.OtherRoomProperty = false;
            energyTrack3.OtherRoomProperty = false;

        }
        else
        {
            Debug.Log("Running...\n");

            now_state = slide_state.StateProperty;
            energyTrack2.EnergyProperty = energyTrack2_amount;
            //int i;
            //Gets set to zero
            //i = energyTrack3.IncreaseProperty;




            if (energyTrack.ActivatedProperty == false || energyTrack.My_ActiveOnEntryAndExit == true || energyTrack.OtherRoomProperty == true)
            {
                if (energyTrack.EnergyProperty > energyTrack_amount)
                {
                    //Debug.Log(energyTrack.EnergyProperty);
                    //Not doing anything
                    new_energyTrack_amount = energyTrack.EnergyProperty - energyTrack_amount;
                    energyTrack.Energy_to_be_added_property = new_energyTrack_amount;

                    if (energyTrack.ActivatedProperty == false && energyTrack.My_ActiveOnEntryAndExit == false)
                    {
                        energyTrack.EnergyProperty = energyTrack.Energy_to_be_added_property;
                    }

                    if (energyTrack.OtherRoomProperty == true)
                    {
                        energyTrack.OtherRoomProperty = false;
                    }
                    //new_energyTrack_amount = 0.0f;
                    //Debug.Log(energyTrack.EnergyProperty);
                }
            }
            else
            {
                energyTrack_amount = 0.0f;
                new_energyTrack_amount = 0.0f;
                energyTrack.Energy_to_be_added_property = energyTrack.EnergyProperty;
                energyTrack.My_ActiveOnEntryAndExit = false;
            }

            //------------------------------------------

            //This tracker is getting reset, why?

            if (energyTrack3.ActivatedProperty == false || energyTrack3.My_ActiveOnEntryAndExit == true || energyTrack3.OtherRoomProperty == true)
            {
                if (energyTrack3.EnergyProperty > energyTrack3_amount)
                {
                    //Debug.Log(energyTrack.EnergyProperty);
                    //Not doing anything
                    new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
                    energyTrack3.Energy_to_be_added_property = new_energyTrack3_amount;

                    if (energyTrack.ActivatedProperty == false && energyTrack3.My_ActiveOnEntryAndExit == false)
                    {
                        energyTrack3.EnergyProperty = energyTrack3.Energy_to_be_added_property;
                    }
                    //new_energyTrack_amount = 0.0f;
                    //Debug.Log(energyTrack.EnergyProperty);

                    if (energyTrack3.OtherRoomProperty == true)
                    {
                        energyTrack3.OtherRoomProperty = false;
                    }
                }
            }
            else
            {
                energyTrack3_amount = 0.0f;
                new_energyTrack3_amount = 0.0f;
                energyTrack3.Energy_to_be_added_property = energyTrack3.EnergyProperty;
                energyTrack3.My_ActiveOnEntryAndExit = false;
            }

            //if(energyTrack3.ActivatedProperty)
            //{
            //    int k = 0;
            //}

            //------------------------------------------

            //if (!energyTrack2.ActivatedProperty)
            //{
            //    if (energyTrack2.EnergyProperty > energyTrack2_amount)
            //    {
            //        new_energyTrack2_amount = energyTrack2.EnergyProperty - energyTrack2_amount;
            //        energyTrack2.EnergyProperty = new_energyTrack2_amount;
            //    }
            //}

            //if (!energyTrack3.ActivatedProperty)
            //{

            //    if (energyTrack3.EnergyProperty > energyTrack3_amount)
            //    {
            //        new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
            //        energyTrack3.EnergyProperty = new_energyTrack3_amount;
            //    }
            //}
        }
    }

    private void OnDestroy()
    {
        energyTrack_amount = energyTrack.EnergyProperty;
        energyTrack2_amount = energyTrack2.EnergyProperty;
        slide_state.StateProperty = now_state;
        //------------------------------------------
        energyTrack3_amount = energyTrack3.EnergyProperty;
        //------------------------------------------

        energyTrack.Energy_to_be_added_property = 0;
        energyTrack3.Energy_to_be_added_property = 0;

        //energyTrack2_amount = energyTrack2.EnergyProperty;
        //energyTrack3_amount = energyTrack3.EnergyProperty;
    }




    public void RunSetup()
    {
        //This changes on re-open before anything else
        //if (energyTrack3.ActivatedProperty == false)
        //{
        //    int j = 0;
        //}

        //if(Instance!=null)
        //{
        //    Destroy(this);
        //    return;
        //}
        //else if (Instance == null)
        //{
        //    Instance = this;

        //    //PlayerPrefs.DeleteAll();

        //    overhead_.SetEnergy(0);
        //    PlayerPrefs.SetFloat("Overall_energy", 0);
        //    PlayerPrefs.SetFloat("Energy", 0);
        //    energyTrack.EnergyProperty = 0;
        //    energyTrack2.EnergyProperty = 0;

        //    //DontDestroyOnLoad(Instance);
        //}

        //if(firstPlay != false)
        //{
        //    PlayerPrefs.SetInt("FirstPlay", 1);
        //}

        //if(PlayerPrefs.GetInt("Firstplay")== 1)
        //{
        //    //runNow = false;
        //    PlayerPrefs.SetInt("FirstPlay", 0);
        //    PlayerPrefs.Save();
        //    Debug.Log("Starting...\n");
        //    firstPlay = true;
        //}
        //else
        //{
        //    //runNow = true;
        //    Debug.Log("Running...\n");
        //    firstPlay = false;
        //}

        if (firstPlay == true)
        {
            Debug.Log("Starting...\n");
            //PlayerPrefs.DeleteAll();

            //overhead_.SetEnergy(0);
            //PlayerPrefs.SetFloat("Overall_energy", 0);
            //PlayerPrefs.SetFloat("Energy", 0);

            energyTrack.EnergyProperty = 0;
            energyTrack2.EnergyProperty = 0;

            //------------------------------------------
            energyTrack3.EnergyProperty = 0;
            //------------------------------------------

            energyTrack.IncreaseProperty = 1;
            energyTrack2.IncreaseProperty = 1;

            //------------------------------------------
            energyTrack3.IncreaseProperty = 1;
            //------------------------------------------

            energyTrack.ActivatedProperty = false;
            energyTrack2.ActivatedProperty = false;

            //------------------------------------------
            energyTrack3.ActivatedProperty = false;
            //------------------------------------------

            energyTrack_amount = 0.0f;
            new_energyTrack_amount = 0.0f;
            //------------------------------------------
            new_energyTrack3_amount = 0.0f;
            //------------------------------------------
            //energyTrack2_amount = 0.0f;
            //------------------------------------------
            energyTrack3_amount = 0.0f;
            //------------------------------------------

            energyTrack.My_firstPlay = true;
            energyTrack3.My_firstPlay = true;

            energyTrack.Energy_to_be_added_property = 0.0f;
            energyTrack3.Energy_to_be_added_property = 0.0f;


            slide_state.StateProperty = false;

            firstPlay = false;

            //Screen.SetResolution(1920, 1080, true, 60);


            energyTrack.My_ActiveOnEntryAndExit = false;
            energyTrack3.My_ActiveOnEntryAndExit = false;


            energyTrack.MyRoomNum = 1;
            energyTrack3.MyRoomNum = 2;
            energyTrack2.MyRoomNum = 0;


            energyTrack.OtherRoomProperty = false;
            energyTrack2.OtherRoomProperty = false;
            energyTrack3.OtherRoomProperty = false;


            overhead_.SetupEnergy();
        }
        else
        {
            Debug.Log("Running...\n");

            now_state = slide_state.StateProperty;
            energyTrack2.EnergyProperty = energyTrack2_amount;
            //int i;
            //Gets set to zero
            //i = energyTrack3.IncreaseProperty;


            overhead_.SetupEnergy();

            if (energyTrack.ActivatedProperty == false || energyTrack.My_ActiveOnEntryAndExit == true || energyTrack.OtherRoomProperty == true)
            {
                if (energyTrack.EnergyProperty > energyTrack_amount)
                {
                    //Debug.Log(energyTrack.EnergyProperty);
                    //Not doing anything
                    new_energyTrack_amount = energyTrack.EnergyProperty - energyTrack_amount;
                    energyTrack.Energy_to_be_added_property = new_energyTrack_amount;

                    if (energyTrack.ActivatedProperty == false && energyTrack.My_ActiveOnEntryAndExit == false)
                    {
                        energyTrack.EnergyProperty = energyTrack.Energy_to_be_added_property;
                    }

                    if (energyTrack.OtherRoomProperty == true)
                    {
                        energyTrack.OtherRoomProperty = false;
                    }
                    //new_energyTrack_amount = 0.0f;
                    //Debug.Log(energyTrack.EnergyProperty);
                }
            }
            else
            {
                energyTrack_amount = 0.0f;
                new_energyTrack_amount = 0.0f;
                energyTrack.Energy_to_be_added_property = energyTrack.EnergyProperty;
                energyTrack.My_ActiveOnEntryAndExit = false;
            }

            //------------------------------------------

            //This tracker is getting reset, why?

            if (energyTrack3.ActivatedProperty == false || energyTrack3.My_ActiveOnEntryAndExit == true || energyTrack3.OtherRoomProperty == true)
            {
                if (energyTrack3.EnergyProperty > energyTrack3_amount)
                {
                    //Debug.Log(energyTrack.EnergyProperty);
                    //Not doing anything
                    new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
                    energyTrack3.Energy_to_be_added_property = new_energyTrack3_amount;

                    if (energyTrack.ActivatedProperty == false && energyTrack3.My_ActiveOnEntryAndExit == false)
                    {
                        energyTrack3.EnergyProperty = energyTrack3.Energy_to_be_added_property;
                    }
                    //new_energyTrack_amount = 0.0f;
                    //Debug.Log(energyTrack.EnergyProperty);

                    if (energyTrack3.OtherRoomProperty == true)
                    {
                        energyTrack3.OtherRoomProperty = false;
                    }
                }
            }
            else
            {
                energyTrack3_amount = 0.0f;
                new_energyTrack3_amount = 0.0f;
                energyTrack3.Energy_to_be_added_property = energyTrack3.EnergyProperty;
                energyTrack3.My_ActiveOnEntryAndExit = false;
            }

            //if(energyTrack3.ActivatedProperty)
            //{
            //    int k = 0;
            //}

            //------------------------------------------

            //if (!energyTrack2.ActivatedProperty)
            //{
            //    if (energyTrack2.EnergyProperty > energyTrack2_amount)
            //    {
            //        new_energyTrack2_amount = energyTrack2.EnergyProperty - energyTrack2_amount;
            //        energyTrack2.EnergyProperty = new_energyTrack2_amount;
            //    }
            //}

            //if (!energyTrack3.ActivatedProperty)
            //{

            //    if (energyTrack3.EnergyProperty > energyTrack3_amount)
            //    {
            //        new_energyTrack3_amount = energyTrack3.EnergyProperty - energyTrack3_amount;
            //        energyTrack3.EnergyProperty = new_energyTrack3_amount;
            //    }
            //}
        }
    }

    public void On_Close()
    {
        energyTrack_amount = energyTrack.EnergyProperty;
        energyTrack2_amount = energyTrack2.EnergyProperty;
        slide_state.StateProperty = now_state;
        //------------------------------------------
        energyTrack3_amount = energyTrack3.EnergyProperty;
        //------------------------------------------

        energyTrack.Energy_to_be_added_property = 0;
        energyTrack3.Energy_to_be_added_property = 0;

        //energyTrack2_amount = energyTrack2.EnergyProperty;
        //energyTrack3_amount = energyTrack3.EnergyProperty;
    }
}