using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dadIndgredients : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    private RectTransform trans;
    private Canvas rootCanvas;

    private void Awake()
    {
        trans = GetComponent<RectTransform>();

        // Automatically grab the Image if you forgot to drag it into the Inspector
        if (image == null)
            image = GetComponent<Image>();

        // Find the top-level Canvas safely
        Canvas canvas = GetComponentInParent<Canvas>();
        if (canvas != null)
            rootCanvas = canvas.rootCanvas;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;

        if (rootCanvas != null)
            transform.SetParent(rootCanvas.transform);

        transform.SetAsLastSibling();

        if (image != null)
            image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        // eventData.position show screen coordinates mouse 
        trans.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData){  
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        if (image != null)
            image.raycastTarget = true;
    }
}