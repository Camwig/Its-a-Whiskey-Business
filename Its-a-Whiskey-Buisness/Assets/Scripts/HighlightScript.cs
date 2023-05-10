using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HighlightScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color highlightColor = Color.yellow;
    public Color originalColor;

    private void Awake()
    {
        // Store the original color of the UI object
        originalColor = GetComponent<Image>().color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Highlight the UI object by changing its color
        GetComponent<Image>().color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Unhighlight the UI object by resetting its color to the original color
        GetComponent<Image>().color = originalColor;
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine;

//public class HighlightScript : MonoBehaviour
//{
//    public Color highlightColor = Color.yellow;
//    private Color[] originalColors;
//    private Image[] childImages;

//    [SerializeField]
//    private Transform[] highlightedChildren;

//    private void Start()
//    {
//        int numHighlightedChildren = highlightedChildren.Length;
//        originalColors = new Color[numHighlightedChildren];
//        childImages = new Image[numHighlightedChildren];

//        for (int i = 0; i < numHighlightedChildren; i++)
//        {
//            Transform childTransform = highlightedChildren[i];
//            childImages[i] = childTransform.GetComponent<Image>();

//            if (childImages[i] != null)
//            {
//                originalColors[i] = childImages[i].color;
//            }
//        }
//    }

//    public void Highlight()
//    {
//        foreach (Image childImage in childImages)
//        {
//            if (childImage != null)
//            {
//                childImage.color = highlightColor;
//            }
//        }
//    }

//    public void Unhighlight()
//    {
//        for (int i = 0; i < childImages.Length; i++)
//        {
//            if (childImages[i] != null)
//            {
//                childImages[i].color = originalColors[i];
//            }
//        }
//    }




//private Image image;
//public GameObject childObject;

//public Color highlightColor = Color.yellow;
//private Color[] originalColors;
//private Image[] images;

//Start is called before the first frame update


//public Color highlightColor = Color.yellow;
//private Image[] childImages;

//private void Start()
//{
//    childImages = transform.GetComponentsInChildren<Image>();
//}
//private void Start()
//{
//    Transform childTransform = transform.Find("Room1Button");
//    if (childTransform == null)
//    {
//        Debug.LogWarning("Child object not found.");
//    }
//    else
//    {
//        image = childTransform.GetComponent<Image>();
//        if (image == null)
//        {
//            Debug.LogWarning("Child object does not have Image component.");
//        }
//    }
//}

//private void Start()
//{
//    int childCount = transform.childCount;
//    originalColors = new Color[childCount];
//    images = new Image[childCount];

//    for (int i = 0; i < childCount; i++)
//    {
//        Transform childTransform = transform.GetChild(i);
//        images[i] = childTransform.GetComponent<Image>();

//        if (images[i] != null)
//        {
//            originalColors[i] = images[i].color;
//        }
//    }
//}

//public void Highlight()
//{
//    for (int i = 0; i < images.Length; i++)
//    {
//        if (images[i] != null)
//        {
//            images[i].color = highlightColor;
//        }
//    }
//}

//public void Unhighlight()
//{
//    for (int i = 0; i < images.Length; i++)
//    {
//        if (images[i] != null)
//        {
//            images[i].color = originalColors[i];
//        }
//    }
//}



//public void Highlight()
//{
//    foreach (Image childImage in childImages)
//    {
//        childImage.color = highlightColor;
//    }
//}

//public void Unhighlight()
//{
//    foreach (Image childImage in childImages)
//    {
//        childImage.color = Color.white;
//    }
//}

//public void Highlight()
//{
//    childObject.GetComponent<Image>().color = Color.yellow;
//}

//public void Unhighlight()
//{
//    childObject.GetComponent<Image>().color = Color.white;
//}


// Update is called once per frame
