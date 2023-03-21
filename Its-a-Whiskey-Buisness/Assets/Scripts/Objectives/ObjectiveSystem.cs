using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
