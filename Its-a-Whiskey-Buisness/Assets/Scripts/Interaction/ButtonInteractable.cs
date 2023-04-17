using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : MonoBehaviour
{
    //Boolean to track activation
    private bool on_off;

    [SerializeField]
    public int Room_num;

    [Header("Events")]
    //Event system to call activation
    public EventSytem onButtonActivate;

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
        onButtonActivate.Raise(this, data);
    }
}
