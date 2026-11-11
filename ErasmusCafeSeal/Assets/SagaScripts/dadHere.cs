using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class dadHere : MonoBehaviour, IDropHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        dadIndgredients knot = dropped.GetComponent<dadIndgredients>();
        knot.parentAfterDrag = transform;
    }
}
