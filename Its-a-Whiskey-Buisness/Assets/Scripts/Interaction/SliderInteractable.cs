using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SliderInteractable : MonoBehaviour
{
    private Vector3 mousePosition;
    private float OriginPos;
    private bool is_being_held = false;
    private float newpos_y;

    private enum slide_state {Down,Up,Down_active,Up_active,None};
    private slide_state curr_state;

    [SerializeField]
    public int Room_num;

    [SerializeField]
    public GameObject selectedObject;

    [Header("Events")]
    public EventSytem onSliderActivate;

    private void Start()
    {
        OriginPos = selectedObject.gameObject.transform.localPosition.y;
    }

    private void Awake()
    {
        curr_state = slide_state.None;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint((Input.mousePosition));
        if (is_being_held == true)
        {
            selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, mousePosition.y - newpos_y, 0);
        }

        if(selectedObject.gameObject.transform.localPosition.y < OriginPos && selectedObject.gameObject.transform.localPosition.y > OriginPos - 1.5f)
        {
            curr_state = slide_state.None;
        }

        if(selectedObject.gameObject.transform.localPosition.y >= OriginPos)
        {
            selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, OriginPos, 0);
            if (curr_state == slide_state.None)
            {
                curr_state = slide_state.Up;
            }
        }

        if (selectedObject.gameObject.transform.localPosition.y <= OriginPos - 1.5f)
        {
            selectedObject.gameObject.transform.localPosition = new Vector3(selectedObject.gameObject.transform.localPosition.x, OriginPos - 1.5f, 0);
            if (curr_state == slide_state.None)
            {
                curr_state = slide_state.Down;
            }
        }

        CheckState();
    }

    private void CheckState()
    {
        if(curr_state == slide_state.Up)
        {
            onSliderActivate.Raise(this, false);
            curr_state = slide_state.Up_active;
        }
        else if(curr_state == slide_state.Down)
        {
            onSliderActivate.Raise(this, true);
            curr_state = slide_state.Down_active;
        }
    }

    private void OnMouseDown()
    {
        newpos_y = mousePosition.y - selectedObject.transform.localPosition.y;

        is_being_held = true;
    }

    private void OnMouseUp()
    {
        is_being_held = false;
    }
}
