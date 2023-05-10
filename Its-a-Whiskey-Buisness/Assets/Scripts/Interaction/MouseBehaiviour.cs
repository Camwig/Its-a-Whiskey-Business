using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseBehaiviour : MonoBehaviour
{
    //Selectedobject is the spirte object attached to the mouse object
    public GameObject selectedObject;
    //Current position of the mouse
    private Vector3 mousePosition;
    //Original position of the click of a mouse for drawing the line
    private Vector3 origin_pos;
    //Offset for calculating the new distance of the mouse from its original click position
    private Vector3 offset;
    //Sprite renderer
    private SpriteRenderer sprender;
    //Line renderer
    private LineRenderer line;
    //Boolean value to track if a mouse clicks position has been saved
    private bool got_pos = false;
    //New angle at which the line must be at to connect to the mouse object
    private float angle;
    //Speed of rotation of the line
    private float roatationSpeed;

    //Target 2d collider for the interactable objects
    private Collider2D targetObject;
    //Target 2D for the UI elements
    private Collider2D targetUI;

    //Boolean to track if the mouse sprite is over a UI button element
    private bool NoLongerHovering;

    //TExture 2D for the mouse cursor
    public Texture2D mouseArrow;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the colour of the line
        Color c1 = Color.white;

        //Retrieves the sprite renderer attached to the object
        sprender = selectedObject.gameObject.GetComponentInChildren<SpriteRenderer>();
        sprender.enabled = false;
        //Retrieves the line renderer for the object
        line = selectedObject.gameObject.GetComponentInChildren<LineRenderer>();
        line.sortingOrder = 8;

        //Sets the line texture and colour
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.startColor= c1;
        line.endColor= c1;

        //Sets the target object to null
        targetObject = null;

        //Sets the target UI to null
        targetUI = null;

        //Sets the offset
        offset = new Vector3(0, 0, 2);

        //Sets the rotation speed
        roatationSpeed = 10f;

        //Sets the cursor visability to false
        Cursor.visible = false;

        //Sets the boolean to true at initial startup
        NoLongerHovering = true;

        SetCursorSprite();
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the sprite render renderer component
        Renderer sprendery = GetComponent<Renderer>();

        //Sets the renderer to true
        sprender.enabled = true;
        //Sets the mouse position to that of the screen world point
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));
        //Sets the selectedobject local position to the mouse position
        selectedObject.gameObject.transform.localPosition = new Vector3(mousePosition.x, mousePosition.y, 0);
        //Sets the sorting order of the sprite renderer
        sprendery.sortingOrder = 10;

        //Checks if the cursor is NOT hovering over any button
        if (NoLongerHovering == true)
        {
            //Sets the object to the correct sprite
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Mouse_");
        }
        //Checks if the cursor is hovering over any button
        else if (NoLongerHovering == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Mouse_click_hand");
        }
        //Sets the rotation of the object origin
        this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        //Checks if the targetUI object is overallaping with any UI elements
        if (targetUI = Physics2D.OverlapPoint(mousePosition))
        {
            //Sets the correct sprite
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Mouse_click_hand"); 
        }

        //Checks if the mouse button is being clicked
        if (Input.GetMouseButton(0))
        {
            //Sets the sprite renderer to true
            sprender.enabled = true;

            //Sets the object to the correct sprite
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Mouse_click_hand");

            //Checks if we have the new position of the mouse when it has been clicked
            if (got_pos == false)
            {
                //Sets the target object to any overlapping 2d physics body
                targetObject = Physics2D.OverlapPoint(mousePosition);

                //Sets the got position value to true
                got_pos = true;
            }

            //if target object picked up on a 2d physics body
            if (targetObject != null)
            {
                //Enable the line renderer
                line.enabled = true;
                //Sets the new origin position to the itself plus the offset
                origin_pos = new Vector3 (targetObject.transform.position.x + offset.x, targetObject.transform.position.y + offset.y,1);
                //Sets the line start position to the origin
                line.SetPosition(0, origin_pos);
                //Sets the line end position to the new position of the mouse object
                line.SetPosition(1, selectedObject.gameObject.transform.localPosition);

                //Sets the rotation of the line to a basic angle of zero insruing the line does not rotate around the z-axis
                Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                //Slerping is spherically interpolating
                line.transform.rotation = Quaternion.Slerp(targetObject.transform.rotation, rotation, roatationSpeed * Time.deltaTime);
            }
        }
        
        //Checks if the mouse button is up
        if(Input.GetMouseButtonUp(0))
        {
            //disables and resets the appropriate variables and plays and audio clip
            sprender.enabled = false;
            got_pos = false;
            line.enabled = false;
            targetObject = null;
            origin_pos = new Vector3(0, 0, 0);

            Clicksound();
        }
    }

    //event to trigger a change in sprite when the mouse enters the space of a button
    public void ChangeSprite()
    {
        EventSytem HoverMouse = Resources.Load<EventSytem>("HoverMouse");
        HoverMouse.Raise(this, false);
    }

    //event to trigger a change in sprite when the mouse enters the space of a button
    public void ChangeSprite2()
    {
        EventSytem HoverMouse = Resources.Load<EventSytem>("HoverMouse");
        HoverMouse.Raise(this, true);
    }

    //Sets the no longer hovering value to the correct state of the boolean
    public void RaisedEvent(Component sender, object data)
    {
        if(data is bool)
        {
            NoLongerHovering = (bool)data;
        }
    }

    //Sets the cursor to visble
    public void SetCursorOn()
    {
        Cursor.visible = true;
    }

    //sets the cursor to invsible
    public void SetCursorfalse()
    {
        Cursor.visible = false;
    }

    //Sets the sprite of the actual mouse cursor for the pause menu and the end screens.
    public void SetCursorSprite()
    {
        CursorMode mode = CursorMode.ForceSoftware;
        float xspot = mouseArrow.width / 4;
        float yspot = mouseArrow.height / 4;
        Vector2 hotspot = new Vector2(xspot, yspot);
        Cursor.SetCursor(mouseArrow, hotspot, mode);
    }


    private void Clicksound()
    {
        //AUDIO!
    }
}
