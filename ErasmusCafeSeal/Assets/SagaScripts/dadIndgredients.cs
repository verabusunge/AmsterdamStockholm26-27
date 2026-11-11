using System.Collections;
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

    private void Start(){
        trans = GetComponent<RectTransform>(); }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begindrag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        if (image != null) image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("Dragging");
        Vector3 newPosition = new Vector3(trans.position.x, Input.mousePosition.get());
        newPosition.x = Input.mousePosition.get();
        trans.position = newPosition;
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
