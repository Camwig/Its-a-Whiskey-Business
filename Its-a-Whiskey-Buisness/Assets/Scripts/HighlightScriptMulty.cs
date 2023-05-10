using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color highlightColor;

    private GameObject highlightedChild;
    private Color originalColor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Get the child object that is being hovered over
        highlightedChild = eventData.pointerEnter;

        // Store the original color of the child object
        originalColor = highlightedChild.GetComponent<Image>().color;

        // Highlight the child object by changing its color
        highlightedChild.GetComponent<Image>().color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Unhighlight the child object by resetting its color to the original color
        highlightedChild.GetComponent<Image>().color = originalColor;
    }
}


//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.EventSystems;
//using System.Collections.Generic;

//public class HighlightScriptMulty : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
//{
//    public List<GameObject> highlightedChildren;
//    public Color highlightColor;

//    private Dictionary<GameObject, Color> originalColors = new Dictionary<GameObject, Color>();

//    public void OnPointerEnter(PointerEventData eventData)
//    {
//        // Highlight each child object by changing its color
//        foreach (GameObject child in highlightedChildren)
//        {
//            // Store the original color if it hasn't been stored already
//            if (!originalColors.ContainsKey(child))
//            {
//                originalColors.Add(child, child.GetComponent<Image>().color);
//            }

//            child.GetComponent<Image>().color = highlightColor;
//        }
//    }

//    public void OnPointerExit(PointerEventData eventData)
//    {
//        // Unhighlight each child object by resetting its color to the original color
//        foreach (GameObject child in highlightedChildren)
//        {
//            Color originalColor;
//            if (originalColors.TryGetValue(child, out originalColor))
//            {
//                child.GetComponent<Image>().color = originalColor;
//            }
//        }
//    }
//}

