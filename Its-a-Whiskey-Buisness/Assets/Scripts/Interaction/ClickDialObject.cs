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

    [SerializeField]
    public int Room_num;

    [Header("Events")]
    public EventSytem onDialActivate;

    private void Start()
    {
        //curr_point = Cardinal_points.E_Active;
        power = 0;
        rotation = 0;
        roatationSpeed = FrictionSpeed.RotationSpeed;

        check_time = false;
        new_time = 0;
        origin_time = 0;
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));

        //float roatationSpeed = 10f;

        Vector2 direction = mousePosition - this.transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //angle = Mathf.Clamp(angle, 30, 330);

        //Clamps it between certain angles
        //annoying that it isnt in the same format
        //Have to remeber this 
        //if((angle > 30))
        //{
        //    angle = 30;
        //}

        //if (angle < -30)
        //{
        //    angle = 330;
        //}

        //Debug.Log(power);

        //
        Quaternion old_rotate = this.transform.rotation;

        curr_point = Cardinal_points.None;


        if (check_time == true)
        {
            //origin_time = Time.deltaTime;
            if (new_time >= origin_time + 0.01125f)
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

            if (is_being_held == true)
            {

                Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                //Slerping is spherically interpolating
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, roatationSpeed * Time.deltaTime);


                //if (this.transform.rotation.z >= 330 && this.transform.rotation.z >= 30)
                //{
                //    //Never runs
                //    this.transform.rotation = old_rotate.eulerAngles;
                //}

            }

            if (this.transform.eulerAngles.z <= 315 && this.transform.eulerAngles.z >= 225)
            {
                check_time = true;
                origin_time = Time.deltaTime;

                if (curr_point == Cardinal_points.None)
                {
                    curr_point = Cardinal_points.E;
                }
            }
            
            if (this.transform.eulerAngles.z >= 135 && this.transform.eulerAngles.z <= 225)
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
            onDialActivate.Raise(this, 100);
            curr_point = Cardinal_points.E_Active;
        }
        else if (curr_point == Cardinal_points.S)
        {
            onDialActivate.Raise(this, 5000);
            curr_point = Cardinal_points.S_Active;
        }
        else if (curr_point == Cardinal_points.None)
        {
            onDialActivate.Raise(this, 1);
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
