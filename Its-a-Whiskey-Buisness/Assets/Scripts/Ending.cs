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
    public float MinimumEnergy;

    [SerializeField]
    public float MaximumEnergy;

    public float winner;

    public void OnButtonClick()
    {
        float final_value =0.0f;

        if(overhead_.returnEnergy() >= (MaximumEnergy /2))
        {
            final_value = overhead_.returnEnergy() + objectives.RetrunDeduction();
        }
        else if(overhead_.returnEnergy() < (MaximumEnergy / 2))
        {
            final_value = overhead_.returnEnergy() - objectives.RetrunDeduction();
        }

        Debug.Log(final_value);

        //if (final_value >= MinimumEnergy && final_value <= MaximumEnergy)
        //{
        //    winningpanel.SetActive(winningpanel);
        //}
        //else
        //{
        //    losingpanel.SetActive(losingpanel);
        //}

        losingpanel.SetActive(losingpanel);
    }

    public void Resume()
    {
        winningpanel.SetActive(false);
        losingpanel.SetActive(false);
    }

    public void Return()
    {
        mainPanel.SetActive(false);

    }
}
