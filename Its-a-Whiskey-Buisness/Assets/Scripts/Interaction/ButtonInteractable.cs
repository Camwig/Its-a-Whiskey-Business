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

    public AK.Wwise.Event OpenButton;
    public AK.Wwise.Event CloseButton;

    // Start is called before the first frame update
    void Start()
    {
        //Set the boolen to false initially
        on_off = false;
    }

    //Function that runs on being clicked
    private void OnMouseDown()
    {
        float data = 0;
        //Sets the button on if it is off and vice versa
        switch(on_off)
        {
            case true:
                on_off = false;
                data = 60;
                break;
            case false:
                on_off = true;
                data = 180;
                break;
        }

        if (temperature_not_power == true)
        {
            onButtonActivate.Raise(this, data);
            CloseButton.Post(gameObject);
        }

        else if (temperature_not_power == false)
        {
            onButtonActivate.Raise(this, on_off);
            OpenButton.Post(gameObject);
        }
    }
}
