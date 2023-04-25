using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDialObject : MonoBehaviour
{
    private Vector3 mousePosition;
    private Collider2D targetObject;
    private Vector3 offset;
    private bool is_being_held = false;
    private float angle;
    private enum Cardinal_points { E, S, W, N , E_Active,S_Active,W_Active,N_Active,None};
    Cardinal_points curr_point;
    private int power;
    private int rotation;

    private float roatationSpeed;

    private float new_time;
    private bool check_time;
    private float origin_time;

    public AK.Wwise.Event DialTick;

    //Object attached to this script
    public GameObject selectedObject;

    [SerializeField]
    public int Room_num;

    [SerializeField]
    [Header("Please only enter three")]
    List<int> Values;

    [Header("Events")]
    public EventSytem onDialActivate;

    private void Start()
    {
        //curr_point = Cardinal_points.E_Active;
        power = 0;
        rotation = 0;
        //roatationSpeed = FrictionSpeed.LeverSpeed;
        roatationSpeed = 15.0f;

        check_time = false;
        new_time = 0;
        origin_time = 0;
    }

    private void Awake()
    {
        //Upon activation will set the rotation
        selectedObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));

        //float roatationSpeed = 10f;

        Vector2 direction = mousePosition - selectedObject.transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //angle = Mathf.Clamp(angle, 30, 330);

        //Clamps it between certain angles
        //annoying that it isnt in the same format
        //Have to remeber this 
        //if ((angle >= 30))
        //{
        //    angle = 30;
        //    Debug.Log(angle);
        //}

        //if(angle <= 30)
        //{
        //    angle += 360;
        //}
        //else if(angle >= 330)
        //{
        //    angle -= 360;
        //}

        //angle = Mathf.Repeat(angle, 360);

        //if(angle ==30)
        //{
        //    if ((angle >= 30))
        //    {
        //        angle = 30;
        //    }
        //}

        //else if( angle == 330)
        //{
        //    if (angle <= 330)
        //    {
        //        angle = 330;
        //    }
        //}


        //else if (angle <= -30)
        //{
        //    angle = -30;
        //    Debug.Log(angle);
        //}

        //if(angle < 30 && angle > -30)
        //{
        //    angle = 0;
        //    Debug.Log(angle);
        //}
        //else
        //{
        //    angle= 180;
        //    Debug.Log(angle);
        //}

        //if ((angle > 30))
        //{
        //    angle = 30;
        //}

        //if (angle < -30)
        //{
        //    angle = 330;
        //}

        //Debug.Log(angle);

        //
        //Quaternion old_rotate = this.transform.rotation;

        curr_point = Cardinal_points.None;


        if (check_time == true)
        {
            //origin_time = Time.deltaTime;
            if (new_time >= origin_time + 0.001125f)
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
        else if (check_time == false)
        {
            //Using this to clamp it between certain angles
            if (selectedObject.transform.eulerAngles.z <= 135 || selectedObject.transform.eulerAngles.z >= 225)
            {
                if (is_being_held == true)
                {

                    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                    //Slerping is spherically interpolating
                    selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);


                    //if (this.transform.rotation.z >= 330 && this.transform.rotation.z >= 30)
                    //{
                    //    //Never runs
                    //    this.transform.rotation = old_rotate.eulerAngles;
                    //}

                }
            }
            else if(selectedObject.transform.eulerAngles.z > 135 && selectedObject.transform.eulerAngles.z < 180)
            {
                Quaternion rotation = Quaternion.AngleAxis(134.9f, Vector3.forward);
                selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);
            }
            else if (selectedObject.transform.eulerAngles.z < 225 && selectedObject.transform.eulerAngles.z > 180)
            {
                Quaternion rotation = Quaternion.AngleAxis(225.1f, Vector3.forward);
                selectedObject.transform.rotation = Quaternion.Slerp(selectedObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);
            }

            if (selectedObject.transform.eulerAngles.z <= 315 && selectedObject.transform.eulerAngles.z >= 225)
            {
                check_time = true;
                origin_time = Time.deltaTime;

                if (curr_point == Cardinal_points.None)
                {
                    curr_point = Cardinal_points.E;
                }
            }
            
            if (selectedObject.transform.eulerAngles.z >= 135 && selectedObject.transform.eulerAngles.z <= 225)
            {
                check_time = true;
                origin_time = Time.deltaTime;

                if (curr_point == Cardinal_points.None)
                {
                    curr_point = Cardinal_points.S;
                }
            }
            //else
            //{
                //curr_point = Cardinal_points.None;
            //}
            //else
            //{
            //curr_point = Cardinal_points.None;
            //}


            CheckState();
        }
    }

    private void CheckState()
    {
        if (curr_point == Cardinal_points.E)
        {
            onDialActivate.Raise(this, Values[1]);
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

        }
        //else if (curr_state == slide_state.Pos2)
        //{
        //    onDialActivate.Raise(this, 1);
        //    //on_off2 = true;
        //    curr_state = slide_state.Pos2_active;
        //}
        //else if (curr_state == slide_state.Pos3)
        //{
        //    onDialActivate.Raise(this, 500);
        //    //on_off2 = true;
        //    curr_state = slide_state.Pos3_active;
        //}
    }

    private void OnMouseDown()
    {
        is_being_held = true;
    }

    private void OnMouseUp()
    {
        is_being_held = false;
    }
}
