using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mode : MonoBehaviour
{

    public Button easy;
    public Button Normal;

    private static bool easyOrNo;

    private ObjectiveSystem objectives;

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
            objectives.Times = 0.05f;
        }
        else
        { 
            objectives.Times = 0.1f;
        }
    }

    
}
