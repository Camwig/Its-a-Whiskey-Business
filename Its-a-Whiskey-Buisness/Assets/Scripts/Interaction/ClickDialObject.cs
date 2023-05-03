using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDialObject : MonoBehaviour
{
    //Vector3 to track the mouse position in relation to the object
    private Vector3 mousePosition;
    //Boolean to track if the object is currently being held onto by the mouse
    private bool is_being_held = false;
    //Float value to track the rotation of the object in degrees
    private float angle;
    //Enumerator to track what cardianl direction the dial is facing in and whether it has newly entered that area or not
    private enum Cardinal_points { E, S, W, N , E_Active,S_Active,W_Active,N_Active,None,None_Active};
    //Current enumeration value
    Cardinal_points curr_point;

    //Speed the dial will rotate at
    private float roatationSpeed;

    //Timing variables to help give the dial a more clicking feel

    //New time at which the dial can move again
    private float new_time;
    //Boolean value to check if we need to stop the movement for an amount of time
    private bool check_time;
    //Time value at which the dial enetered the new cardinal direction
    private float origin_time;

    //Object attached to this script
    public GameObject selectedObject;

    //Number of the room this object is corresponding to
    [SerializeField]
    public int Room_num;

    //List to contain the three values the dial can move between
    [SerializeField]
    [Header("Please only enter three")]
    List<int> Values;

    //Event to be triggered that signals the room object this dial is currently tied to.
    [Header("Events")]
    public EventSytem onDialActivate;

    private void Start()
    {
        //Sets the inital values of these select variables upon startup
        roatationSpeed = 15.0f;
        check_time = false;
        new_time = 0;
        origin_time = 0;
        //curr_point = Cardinal_points.None;
    }

    private void Awake()
    {
        //Upon activation will set the rotation
        selectedObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        curr_point = Cardinal_points.None;
    }

    void Update()
    {
        //Sets the mouse position value to that of the current position of the mouse
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));

        //Calculates the direction of the mouse cursor from the forward direction of the gameobject
        Vector2 direction = mousePosition - selectedObject.transform.position;
        //Calculates the angle the object is at in degrees from the forward direction as the origin
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //Checks if the check time boolean is true
        if (check_time == true)
        {
            //Checks if the newtime is greater or equal to the old time plus a couple of milliseconds
            //Essentially creating a sense of the dial waiting for a bit
            if (new_time >= origin_time + 0.001125f)
            {
                //Resets the timing variables values
                check_time = false;
                new_time = 0;
                origin_time = 0;
            }
            else
            {
                //Increases the new time value
                new_time += Time.deltaTime;
            }
        }
        else if (check_time == false)
        {
            //Makes sure to clamp the dial between certain angles
            if (selectedObject.transform.eulerAngles.z <= 135 || selectedObject.transform.eulerAngles.z >= 225)
            {
                //Checks if the dial is currently being held/interected with/being clicked on
                if (is_being_held == true)
                {
                    //Determines a new rotation of the object based off the new angle against the forward direction
                    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                    //Slerps the the object based off the new rotation value and the rotation speed
                    //Slerping is spherically interpolating
                    selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);
                }
            }//Checks if the objects rotation is greater is less than 135 degrees in counter clockwise direction(Clamps the possible rotation of the dial)
            else if(selectedObject.transform.eulerAngles.z > 135 && selectedObject.transform.eulerAngles.z < 180)
            {
                //If it exceeds the rotation resets the rotation to 0.1 less than the limit
                Quaternion rotation = Quaternion.AngleAxis(134.9f, Vector3.forward);
                selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);
            }//Same check as before except on the opposite side
            else if (selectedObject.transform.eulerAngles.z < 225 && selectedObject.transform.eulerAngles.z > 180)
            {
                //If it exceeds the rotation resets the rotation to 0.1 more than the limit
                Quaternion rotation = Quaternion.AngleAxis(225.1f, Vector3.forward);
                selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);
            }
            //Checks if the rotation of the dial is between certain angles
            if (selectedObject.transform.eulerAngles.z <= 45 && selectedObject.transform.eulerAngles.z <= 315)
            {
                //Sets the check time boolean to true which stops movement of the dial for a small amount of time to give it a more click dial feel
                check_time = true;
                origin_time = Time.deltaTime;
                //Sets the cardinal direction enumerator to none

                if(curr_point != Cardinal_points.None_Active)
                {
                    curr_point = Cardinal_points.None;
                }
            }
            //Repeats the process for both of the following checks
            if (selectedObject.transform.eulerAngles.z <= 315 && selectedObject.transform.eulerAngles.z >= 225)
            {
                check_time = true;
                origin_time = Time.deltaTime;

                //Makes sure we are not coming from the wrong directin and somehow bipassed the clamping
                //And makes sure we are not constantly raisning the event
                if (curr_point == Cardinal_points.None || curr_point == Cardinal_points.None_Active)
                {
                    curr_point = Cardinal_points.E;
                }
            }
            
            if (selectedObject.transform.eulerAngles.z >= 45 && selectedObject.transform.eulerAngles.z <= 135)
            {
                check_time = true;
                origin_time = Time.deltaTime;

                if (curr_point == Cardinal_points.None || curr_point == Cardinal_points.None_Active)
                {
                    curr_point = Cardinal_points.S;
                }
            }
        }

        CheckState();
    }

    private void CheckState()
    {
        //checks the current direction enumerator
        if (curr_point == Cardinal_points.E)
        {
            //Raises the event with the appropriate value
            onDialActivate.Raise(this, Values[1]);
            //Sets it to the active version of the cardinal point
            curr_point = Cardinal_points.E_Active;
        }
        else if (curr_point == Cardinal_points.S)
        {
            onDialActivate.Raise(this, Values[2]);
            curr_point = Cardinal_points.S_Active;
        }
        else if (curr_point == Cardinal_points.None)
        {
            onDialActivate.Raise(this, Values[0]);
            curr_point = Cardinal_points.None_Active;
        }
    }

    private void OnMouseDown()
    {
        //Sets the held boolean to be true
        is_being_held = true;
    }

    private void OnMouseUp()
    {
        //Sets the held boolean to be false
        is_being_held = false;
    }
}
