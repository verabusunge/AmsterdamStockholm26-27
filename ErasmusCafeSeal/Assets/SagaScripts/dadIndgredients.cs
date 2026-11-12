using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dadIndgredients : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler //Drag refersd´to dragging the mouse across the screen 
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    private RectTransform trans;
    private Canvas rootCanvas;



    private void Awake()
    { trans = GetComponent<RectTransform>(); // Automatically grab Image if it doesnt drag it into  Inspector
     if (image == null)
     image = GetComponent<Image>();// Find the uppper Canvas 
      Canvas canvas = GetComponentInParent<Canvas>(); //canvas is set as primary parent and stays as the parent when dragged.
      if (canvas != null)
      rootCanvas = canvas.rootCanvas; }



    public void OnBeginDrag(PointerEventData eventData)
    {  Debug.Log("Begin Drag");
 parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
          if (image != null)
            if (image != null)
                image.raycastTarget = false;

        /*  if (rootCanvas != null)
     transform.SetParent(rootCanvas.transform);
           transform.SetAsLastSibling();
     if (image != null)
               image.raycastTarget = false;*/
       }

        public void OnDrag(PointerEventData eventData)  {
        Debug.Log("Dragging");  // eventData.position showing screen coordinates of mouse 
        trans.position = eventData.position; }
    //When you release the letf mouse button the Image/ingredient stays inside the spot because the raycast is hidden for the igredient.


    public void OnEndDrag(PointerEventData eventData){  
        Debug.Log("End Drag"); 
        transform.SetParent(parentAfterDrag); //the image continues to be a child to all images so it can be dropped int the bowl
        if (image != null)
            image.raycastTarget = true; //raycast turns on again if the image isnt dropped here
    }
}