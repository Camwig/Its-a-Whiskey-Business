using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HighlightSpriteScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public SpriteRenderer spriteRenderer;
    public Color highlightColor;

    private Color originalColor;

    private void Awake()
    {
        // Store the original color of the sprite
        originalColor = spriteRenderer.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Highlight the sprite by changing its color
        spriteRenderer.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Unhighlight the sprite by resetting its color
        spriteRenderer.color = originalColor;
    }
}
