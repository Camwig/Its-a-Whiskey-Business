using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingSliderInteractable : MonoBehaviour
{
    //Location of the mouse position
    private Vector3 mousePosition;
    //Initial position of the slider
    private float OriginPos;
    //Boolean to track if it is being held
    private bool is_being_held = false;
    //New float y-position
    private float newpos_y;

    private enum slide_state { Pos1, Pos2, Pos3, Pos1_active, Pos2_active, Pos3_active, None };
    private slide_state curr_state;

    //Values that are used to check if a certain amount of time has passed before continuing to move the slider
    //Which helps to give it that clicking feel
    private float new_time;
    private bool check_time;
    private float origin_time;

    [SerializeField]
    public int Room_num;

    [SerializeField]
    [Header("Please only enter three")]
    List<int> Values;

    [Header("Events")]
    public EventSytem onSlideActivate;

    //Current game object this script is attached to
    public GameObject selectedObject;
    //Diffrent levels of the slider so top,middle and bottom
    enum Option {A,B,C};

    private float prevValue;

    public AK.Wwise.Event HeavyDial;

    //Runs at the beginning of the application
    private void Start()
    {
        //Sets the origin position to be that of the initial y-position of the object
        OriginPos = selectedObject.gameObject.transform.localPosition.y;
        //Initialises all the varaibles
        check_time = false;
        new_time = 0;
        origin_time = 0;
    }


    private void Awake()
    {
        curr_state = slide_state.None;
    }

    // Update is called once per frame
    void Update()
    {
        //The check time boolean is used to stop the object at certain heights/y-positions for a certain amount of time
        if(check_time == true)
        {
            //These two if statements check if the time at which we stopped the object is equal to a copule millisceonds passing
            //Essentially stops the movement of the object for a couple of milliseconds to help give the illusuion of the clicking
            if (new_time >= origin_time + 0.25f)
            {
                check_time = false;
                new_time = 0;
                origin_time = 0;
            }
            else
            {
                new_time += Time.deltaTime;
            }
        }
        else if(check_time == false)
        {
            //Gets the mouse position in terms of screen space
            mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));
            //Checks if the object is being held by the user (holding down left click)
            if (is_being_held == true)
            {
                //Moves the object in relation to the mouses y-position
                selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, mousePosition.y - newpos_y, 0);
                OnDrag();
            }

            if (selectedObject.gameObject.transform.localPosition.y < OriginPos && selectedObject.gameObject.transform.localPosition.y > OriginPos - 3.0f)
            {
                curr_state = slide_state.None;
            }

            //If the mouse moves the object greater or equal to its starting origin
            if (selectedObject.gameObject.transform.localPosition.y >= OriginPos - 1.5f)
            {
                //Resets the y_position to the origin
                selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, OriginPos, 0);
                if (curr_state == slide_state.None)
                {
                    curr_state = slide_state.Pos1;
                }
            }

            //If the object is between these two heights below the origin
            if (selectedObject.gameObject.transform.localPosition.y <= OriginPos - 1.5f && selectedObject.gameObject.transform.localPosition.y >= OriginPos - 1.8f)
            {
                //It will stop the movement
                check_time = true;
                origin_time = Time.deltaTime;

                if (curr_state == slide_state.None)
                {
                    curr_state = slide_state.Pos2;
                }
            }

            //If the mouse attempts to move the object below a certain threshold
            if (selectedObject.gameObject.transform.localPosition.y <= OriginPos - 3.0f)
            {
                //Resets it to the minimum y-position below the the origin
                selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, OriginPos - 3.0f, 0);
                if (curr_state == slide_state.None)
                {
                    curr_state = slide_state.Pos3;
                }
            }

            CheckState();
        }
    }

    private void CheckState()
    {
        if (curr_state == slide_state.Pos1)
        {
            onSlideActivate.Raise(this, Values[0]);
            //on_off2 = false;
            curr_state = slide_state.Pos1_active;
            HeavyDial.Post(gameObject); 
        }
        else if (curr_state == slide_state.Pos2)
        {
            onSlideActivate.Raise(this, Values[1]);
            //on_off2 = true;
            curr_state = slide_state.Pos2_active;
            HeavyDial.Post(gameObject);
        }
        else if (curr_state == slide_state.Pos3)
        {
            onSlideActivate.Raise(this, Values[2]);
            //on_off2 = true;
            curr_state = slide_state.Pos3_active;
            HeavyDial.Post(gameObject);
        }
    }

    public void OnDrag()
    {
        var diff = prevValue - (-selectedObject.gameObject.transform.localPosition.y);
        if (Mathf.Abs(diff) > 1)
        {
            Debug.Log("difference is bigger than 10, playing sound");

            prevValue = (-selectedObject.gameObject.transform.localPosition.y);
        }
    }

    //Sets the new y-position to be that in relation to the mouse position and the object position
    private void OnMouseDown()
    {
        newpos_y = mousePosition.y - selectedObject.transform.localPosition.y;
        //Sets the object to being held
        is_being_held = true;
    }

    //Releases the object and resets the boolean
    private void OnMouseUp()
    {
        is_being_held = false;
    }
}
