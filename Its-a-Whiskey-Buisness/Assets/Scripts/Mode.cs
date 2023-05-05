using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mode : MonoBehaviour
{

    public Button easy;
    public Button Normal;

    private static bool easyOrNo;

    [SerializeField]
    ObjectiveSystem objectives;

    [SerializeField]
    Clock clocks;

    public float newValue;

    public void SlowTime()
    {
        if (easy.GetComponent<Button>() == true)
        {
            
            Time.timeScale = 0.5f;
            easyOrNo = true;
        }
    }
    public void NormalTime()
    {
        if (Normal.GetComponent<Button>() == true)
        {
            Time.timeScale = 1.0f;
            easyOrNo = false;
        }
    }
    public void CheckMode()
    {
        if (easyOrNo == true)
        {
            if (clocks.hours == 9 && clocks.minutes == 00)
            {
                Time.timeScale = 0.5f;
            }
            objectives.Times = 0.05f;
        }
        else if (easyOrNo == false)
        {
            if (clocks.hours == 9 && clocks.minutes == 00)
            {
                Time.timeScale = 1.0f;
            }
            objectives.Times = 0.1f;
        }
    }

    public bool RetrunEasyOrNormal()
    {
        return easyOrNo;
    }

    
}
