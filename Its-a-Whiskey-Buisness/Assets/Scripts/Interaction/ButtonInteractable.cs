using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : MonoBehaviour
{
    //Boolean to track activation
    private bool on_off;

    [SerializeField]
    public bool temperature_not_power;

    [SerializeField]
    public int Room_num;

    [Header("Events")]
    //Event system to call activation
    public EventSytem onButtonActivate;

    private float data;

    private bool firstPlay;

    // Start is called before the first frame update
    void Start()
    {
        //Set the boolen to false initially
        on_off = false;
        //Sets the first play boolean to true
        firstPlay = true;
    }

    private void Update()
    {
        //Checks if it is the first time running this
        if (firstPlay == true)
        {
            //Checks if we are setting temperature
            if (temperature_not_power == true)
            {
                //Intialises the temperature
                data = 60;
                onButtonActivate.Raise(this, data);
                //Sets this to be false as it has now been played
                firstPlay = false;
            }
        }
    }

    //Function that runs on being clicked
    private void OnMouseDown()
    {
        //Sets the button on if it is off and vice versa
        switch(on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                data = 60;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Green Buttle Idle (not pressed)");
                break;
            case false:
                on_off = true;
                data = 180;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Red Button Pressed");
                break;
        }

        //Checks if this object is setting power or temperature and then sends off the apprpriate data
        if (temperature_not_power == true)
        {
            onButtonActivate.Raise(this, data);
        }

        else if (temperature_not_power == false)
        {
            onButtonActivate.Raise(this, on_off);
        }
    }
}
