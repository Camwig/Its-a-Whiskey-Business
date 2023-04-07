using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteraction : MonoBehaviour
{
    //Position of the mouse
    private Vector3 mousePosition;
    //Dont beleive we need these two variables so they may be removed later
    private Collider2D targetObject;
    private Vector3 offset;
    //Boolean to track if it is being held
    private bool is_being_held = false;
    //Angle of the object
    private float angle;
    //Speed of rotation of the object
    private float roatationSpeed;

    //Dont think this is used either
    private static float new_angle;

    //This is also no longer used
    [SerializeField]
    public ObjectPositioing these_objects;

    //Value to track which room we belong to
    [SerializeField]
    public int Room_num;

    //Object attached to this script
    public GameObject selectedObject;

    //Event system for turning on the room using this object
    [Header("Events")]
    [SerializeField]
    public EventSytem onLeverActivate;

    //awake and start can most likely be combined

    private void Awake()
    {
        //Upon activation will set the rotation
        selectedObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Start()
    {
        //Upon activation sets the rotation speed to that of the header object
        roatationSpeed = FrictionSpeed.LeverSpeed;
    }

    void Update()
    {
        //Gets the mouse position in terms of screen space
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));

        //sets the angle of rotation based on the postition of the mouse
        Vector2 direction = mousePosition - selectedObject.transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //Clamps it between certain angles
        //annoying that it isnt in the same format
        //Have to remeber this 
        if ((angle > 30))
        {
            angle = 30;
        }

        if (angle < -30)
        {
            angle = 330;
        }

        //Gets the latest rotation before applying the new angle
        Quaternion old_rotate = selectedObject.transform.rotation;

        //Checks if the object is being held
        if (is_being_held == true)
        {
            //Set the new rotation of the lever object based on the angle value
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //Slerping is spherically interpolating
            selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);

            //Activates the room activation event based on the angle of the object
            //However this currently has a bug which means that if it is rotated at the same angle in the oppositie direction it still activates
            if (angle >= 20)
            {
                onLeverActivate.Raise(selectedObject.GetComponent<LeverInteraction>(), true);
            }
            else
            {
                //Sets the room to inactive if it is not at the appropriate angle
                onLeverActivate.Raise(selectedObject.GetComponent<LeverInteraction>(), false);
            }
        }
    }

    //Checks if the mouse is clicking on the object set the boolean to true
    private void OnMouseDown()
    {
        is_being_held = true;
    }

    //Checks if the mouse is no longer clicking on the object and sets the boolean to false
    private void OnMouseUp()
    {
        is_being_held = false;
    }
}
