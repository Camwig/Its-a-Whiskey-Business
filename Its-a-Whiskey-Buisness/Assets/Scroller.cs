using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float scrollAmount = 1000f; // Adjust the scrolling speed as needed

    public AK.Wwise.Event MouseClick;

    public void ScrollContentDown1()
    {
        // Scroll the content vertically
        scrollRect.verticalNormalizedPosition -= scrollAmount / scrollRect.content.rect.height;

        //Debug.Log(scrollRect.verticalNormalizedPosition);

        MouseClick.Post(gameObject);

        if (scrollRect.verticalNormalizedPosition < -0.02405182)
        {
            scrollRect.verticalNormalizedPosition += scrollAmount / scrollRect.content.rect.height;
        }
    }

    public void ScrollContentUp1()
    {
        // Scroll the content vertically
        scrollRect.verticalNormalizedPosition += scrollAmount / scrollRect.content.rect.height;

        //Debug.Log(scrollRect.verticalNormalizedPosition);

        MouseClick.Post(gameObject);

        if (scrollRect.verticalNormalizedPosition > 0.9970921)
        {
            scrollRect.verticalNormalizedPosition -= scrollAmount / scrollRect.content.rect.height;
        }
    }
}
