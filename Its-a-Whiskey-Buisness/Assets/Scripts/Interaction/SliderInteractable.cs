using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SliderInteractable : MonoBehaviour
{
    //Position of the mouse
    private Vector3 mousePosition;
    //Original position of the slider
    private float OriginPos;
    //Boolean to track if its being held
    private bool is_being_held = false;
    //New position in the y position
    private float newpos_y;

    //enumerator state for the slider
    private enum slide_state {Down,Up,Down_active,Up_active,None};
    //Current state for the slider
    private slide_state curr_state;

    //Room number that this object resides in
    [SerializeField]
    public int Room_num;

    //Object attached to this script
    [SerializeField]
    public GameObject selectedObject;

    //Event to for the changing of values
    [Header("Events")]
    public EventSytem onSliderActivate;

    //Boolean to let the script no when it can play a sound clip
    //As it would play on boot up if not
    private bool CanPlay;

    private void Start()
    {
        //Sets the origin positon of the object to the sliders initial y position
        OriginPos = selectedObject.gameObject.transform.localPosition.y;

        //Set can play to false
        CanPlay = false;
    }

    private void OnEnable()
    {
        //Sets the current state to none
        curr_state = slide_state.None;
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the mouse position in refrence to the screen space
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));
        //checks if the object is being held onto by the mouse
        if (is_being_held == true)
        {
            //Sets the object attached to this script position based on the y position of the mouse
            selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, mousePosition.y - newpos_y, 0);
            //Sets this boolean to true to let it know it can play sound
            CanPlay = true;
        }
        else
        {
            //Sets this boolean to false to let it know it cant play sound
            CanPlay = false;
        }
        //Checks if the slider object is within a certain range
        if(selectedObject.gameObject.transform.localPosition.y < OriginPos && selectedObject.gameObject.transform.localPosition.y > OriginPos - 1.5f)
        {
            //Sets the current state to none
            curr_state = slide_state.None;
        }

        //If the selected object is above the original y position or equal to it
        if(selectedObject.gameObject.transform.localPosition.y >= OriginPos)
        {
            //sets the selected object to the origin position
            selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, OriginPos, 0);
            //If there is no current state
            if (curr_state == slide_state.None)
            {
                //set ths current state to up
                curr_state = slide_state.Up;
            }
        }

        //if the selected object is below the orginal position minus an amount
        if (selectedObject.gameObject.transform.localPosition.y <= OriginPos - 1.5f)
        {
            //set the selected objects position to that of the minimum
            selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, OriginPos - 1.5f, 0);
            //If there is no current state
            if (curr_state == slide_state.None)
            {
                //Sets the current state to down
                curr_state = slide_state.Down;
            }
        }

        CheckState();
    }

    private void CheckState()
    {
        //checks the current state
        if(curr_state == slide_state.Up)
        {
            //raise the event with the approriate value
            onSliderActivate.Raise(this, false);
            //Set the currnt state to active
            curr_state = slide_state.Up_active;

            //if it can play sound play it
            if (CanPlay == true)
            {
                //Audio!
            }
        }
        
        if(curr_state == slide_state.Down)
        {
            onSliderActivate.Raise(this, true);
            curr_state = slide_state.Down_active;

            if (CanPlay == true)
            {
                //Audio!
            }
        }
    }

    private void OnMouseDown()
    {
        //Sets the new position in the y to that of the y position of the mouse minus the objects
        newpos_y = mousePosition.y - selectedObject.transform.localPosition.y;
        //Sets being held to true
        is_being_held = true;
    }

    private void OnMouseUp()
    {
        //Sets being held to false
        is_being_held = false;
    }
}
