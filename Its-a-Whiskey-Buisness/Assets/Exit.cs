using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private bool on_off;

    private bool firstPlay;

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

    private void OnMouseDown()
    {
        //Sets the button on if it is off and vice versa
        switch (on_off)
        {
            case true:
                //Sets the appropriate data and changes the sprite
                on_off = false;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Exit button unpressed");
                //ButtonOpen.Post(gameObject);
                break;

            case false:
                on_off = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Exit button pressed");
                // ButtonClose.Post(gameObject);
                break;
        }
    }
}
