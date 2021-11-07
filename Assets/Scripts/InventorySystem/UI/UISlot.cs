using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UISlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        var dragItemTransform = eventData.pointerDrag.transform;
        dragItemTransform.SetParent(transform);
        dragItemTransform.localPosition = Vector3.zero;
    }
}
