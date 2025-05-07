using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    private bool on_off;

    public GameObject up;
    public GameObject down;
    public GameObject Smallup;
    public GameObject Smalldown;
    public GameObject folder;
    public GameObject trash;
    public GameObject exit;
    public GameObject scroller;

    [Header("Events")]
    //Event system to call activation
    //public EventSytem onButtonActivate;

    private bool firstPlay;

    //public AK.Wwise.Event ButtonOpen;
    //public AK.Wwise.Event ButtonClose;

    // Start is called before the first frame update
    void Start()
    {
        //Set the boolen to false initially
        on_off = false;
        //Sets the first play boolean to true
        firstPlay = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (firstPlay == true)
        {
                //onButtonActivate.Raise(this, data);
                //Sets this to be false as it has now been played
                firstPlay = false;
        }
    }
    public void Folder()
    {
        /*//Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                folder.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                folder.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }*/
        Debug.Log("foldery");
    }
    public void Trash()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                trash.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                trash.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
        Debug.Log("Trashy");
    }
    public void Up()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                up.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                up.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
    }

    public void Down()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                down.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                down.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
    }

    public void SmallUp()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                Smallup.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                Smallup.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
    }
    public void SmallDown()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                Smalldown.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                Smalldown.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
    }

    public void Scroller()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                scroller.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button unpressed");
                //ButtonOpen.Post(gameObject);
                
                break;

            case false:
                on_off = true;
                scroller.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("folder button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
    }

    public void Exit()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                exit.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("exit button unpressed");
                //ButtonOpen.Post(gameObject);

                break;

            case false:
                on_off = true;
                exit.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Exit button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
        Debug.Log("Exity");
    }
}
