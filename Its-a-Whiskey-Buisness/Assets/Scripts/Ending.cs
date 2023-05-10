using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    //Hold the panel objects
    public GameObject winningpanel;
    public GameObject losingpanel;
    public GameObject mainPanel;

    //Overhead object
    [SerializeField]
    Overhead overhead_;

    //Objective object
    [SerializeField]
    ObjectiveSystem objectives;

    //Mouse Object
    [SerializeField]
    MouseBehaiviour mouse_;

    //Minmum energy value
    [SerializeField]
    public float MinimumEnergy;

    //Maximum energy value
    [SerializeField]
    public float MaximumEnergy;

    //Mode object
    [SerializeField]
    Mode modeys;


    public void OnButtonClick()
    {
        //Sets the mouse cursor to on
        mouse_.SetCursorOn();

        //Sets the final value to zero
        float final_value =0.0f;

        //Check if the all the objectives have been failed
        if (objectives.AllObjectivesFailed() == true)
        {
            //Set the losing panel to on
            losingpanel.SetActive(losingpanel);
        }
        else
        {
            //Checks if the deduction value is greater to equal to minus twenty
            if (objectives.RetrunDeduction() >= -20)
            {
                //Checks if the final energy value is gerater or equal to the maximum energy by half
                if (overhead_.returnEnergy() >= (MaximumEnergy / 2))
                {
                    //We then add the deduction value

                    //Was +
                  final_value = overhead_.returnEnergy() - objectives.RetrunDeduction();
                }
                //if it is less than the half
                else if (overhead_.returnEnergy() < (MaximumEnergy / 2))
                {
                    //subtract the value

                    //Was -
                  final_value = overhead_.returnEnergy() + objectives.RetrunDeduction();
                }

                //if this final value is between the minimum and maximum energy
                if (final_value >= MinimumEnergy && final_value <= MaximumEnergy)
                {
                    //Set the pannel to wining
                    winningpanel.SetActive(winningpanel);
                }
                else
                {
                    //set panel to lost
                    losingpanel.SetActive(losingpanel);
                }
            }
            else
            {
                //set panel to lost
                losingpanel.SetActive(losingpanel);
            }
        }
    }

    public void Resume()
    {
        //Sets both panels to false
        winningpanel.SetActive(false);
        losingpanel.SetActive(false);
    }

    
}
