using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public GameObject winningpanel;
    public GameObject losingpanel;
    public GameObject mainPanel;

    [SerializeField]
    Overhead overhead_;

    [SerializeField]
    ObjectiveSystem objectives;

    [SerializeField]
    MouseBehaiviour mouse_;

    [SerializeField]
    public float MinimumEnergy;

    [SerializeField]
    public float MaximumEnergy;

    public float winner;

    [SerializeField]
    Mode modeys;


    public void OnButtonClick()
    {
        mouse_.SetCursorOn();

        float final_value =0.0f;

        if (objectives.AllObjectivesFailed() == true)
        {
            losingpanel.SetActive(losingpanel);
            //Debug.Log("Failed");
        }
        else
        {
            //Debug.Log("Not Failed");

            if (objectives.RetrunDeduction() >= -20)
            {
            
                winningpanel.SetActive(winningpanel);
            
                if (overhead_.returnEnergy() >= (MaximumEnergy / 2))
                {
                  final_value = overhead_.returnEnergy() + objectives.RetrunDeduction();
                }
                else if (overhead_.returnEnergy() < (MaximumEnergy / 2))
                {
                  final_value = overhead_.returnEnergy() - objectives.RetrunDeduction();
                }

                //Debug.Log(final_value);

                if (final_value >= MinimumEnergy && final_value <= MaximumEnergy)
                {
                    winningpanel.SetActive(winningpanel);
                }
                else
                {
                    losingpanel.SetActive(losingpanel);
                }
            }
            else
            {
                losingpanel.SetActive(losingpanel);
            }
        }
    }

    public void Resume()
    {
        winningpanel.SetActive(false);
        losingpanel.SetActive(false);
    }

    
}
