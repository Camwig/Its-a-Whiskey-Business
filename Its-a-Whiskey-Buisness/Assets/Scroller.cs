using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float scrollAmount = 10000f; // Adjust the scrolling speed as needed

    public void ScrollContentDown1()
    {
        // Scroll the content vertically
        scrollRect.verticalNormalizedPosition -= scrollAmount / scrollRect.content.rect.height;
    }

    public void ScrollContentUp1()
    {
        // Scroll the content vertically
        scrollRect.verticalNormalizedPosition += scrollAmount / scrollRect.content.rect.height;
    }
}
