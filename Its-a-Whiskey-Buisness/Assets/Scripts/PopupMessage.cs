using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class PopupMessage : MonoBehaviour
{
    public bool isShowing = false;

    private Canvas canvas;
    private Text text;

    void Start()
    {
        canvas = GetComponentInParent<Canvas>();
        text = GetComponent<Text>();
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (isShowing)
        {
            canvas.GetComponent<GraphicRaycaster>().blockingObjects = GraphicRaycaster.BlockingObjects.All;
        }
        else
        {
            canvas.GetComponent<GraphicRaycaster>().blockingObjects = GraphicRaycaster.BlockingObjects.None;
        }
    }

    public void ShowPopupMessage()
    {
        isShowing = true;
        gameObject.SetActive(true);
    }

    public void OnMouseDown()
    {
        isShowing = false;
        gameObject.SetActive(false);
    }
}
