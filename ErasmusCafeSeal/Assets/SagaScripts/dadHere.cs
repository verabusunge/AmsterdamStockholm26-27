using UnityEngine;
using UnityEngine.EventSystems;

public class dadHere : MonoBehaviour, IDropHandler
{
    [Tooltip("If checked, only one ingredient can be placed her at a time.")]
    public bool allowOnlyOneItem = true;

    public void OnDrop(PointerEventData eventData){
        if (allowOnlyOneItem && transform.childCount > 0)
            return;
        GameObject droppedObj = eventData.pointerDrag;
        if (droppedObj != null && droppedObj.TryGetComponent(out dadIndgredients ingredient)){
            ingredient.parentAfterDrag = transform;
            Debug.Log($"{droppedObj.name} dropped into {gameObject.name}");
        }
    }
}
