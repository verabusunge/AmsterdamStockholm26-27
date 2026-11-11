using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;


public class dadIndgredients : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
   // public int Ingredients;
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    RectTransform trans;

    private void Start()
    {
        trans = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begindrag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        if (image != null) image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        Vector2 newPosition = new Vector2(trans.position.x, Input.mousePosition.y); 
        newPosition.y = Input.mousePosition.y;
        trans.position = newPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
