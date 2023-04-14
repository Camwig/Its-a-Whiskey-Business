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
    private enum Cardinal_points { E, S, W, N };
    Cardinal_points curr_point;
    private int power;
    private int rotation;

    private float roatationSpeed;

    private float new_time;
    private bool check_time;
    private float origin_time;

    private void Start()
    {
        curr_point = Cardinal_points.E;
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

                //
                //if(selectedObject.transform.rotation.z >= 330 && selectedObject.transform.rotation.z >= 30)
                //{
                //    //Never runs
                //    selectedObject.transform.rotation = old_rotate;
                //}
                //
            }

            if(this.transform.eulerAngles.z <= 45 && this.transform.eulerAngles.z <= 315)
            {
                check_time = true;
                origin_time = Time.deltaTime;
            }

            //Only increases rotation at 135 degrees

            //if (this.transform.eulerAngles.z <= 45 && this.transform.eulerAngles.z <= 315)
            //{
            //    if (curr_point == Cardinal_points.N)
            //    {
            //        if (rotation >= 3)
            //        {
            //            //Never runs
            //            power++;
            //            rotation = 0;
            //        }
            //    }

            //    //if(curr_point==Cardinal_points.S)
            //    //{
            //    //    if(rotation >=-3)
            //    //    {
            //    //        //Never runs
            //    //        power--;
            //    //        rotation = 0;
            //    //    }
            //    //}

            //    curr_point = Cardinal_points.E;
            //}

            //if (this.transform.eulerAngles.z <= 315 && this.transform.eulerAngles.z >= 225)
            //{
            //    if (curr_point == Cardinal_points.E)
            //    {
            //        rotation++;
            //    }
            //    //if(curr_point==Cardinal_points.W)
            //    //{
            //    //    rotation--;
            //    //}
            //    curr_point = Cardinal_points.S;
            //}


            //if (this.transform.eulerAngles.z >= 135 && this.transform.eulerAngles.z <= 225)
            //{
            //    //Never true
            //    if (curr_point == Cardinal_points.S)
            //    {
            //        rotation++;
            //    }
            //    //if(curr_point==Cardinal_points.N)
            //    //{
            //    //    rotation--;
            //    //}
            //    curr_point = Cardinal_points.W;
            //}

            //if (this.transform.eulerAngles.z >= 45 && this.transform.eulerAngles.z <= 135)
            //{
            //    if (curr_point == Cardinal_points.W)
            //    {
            //        rotation++;
            //    }
            //    //if (curr_point == Cardinal_points.E)
            //    //{
            //    //    rotation--;
            //    //}
            //    curr_point = Cardinal_points.N;
            //}
        }
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
