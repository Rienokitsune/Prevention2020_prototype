using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AppWindowScript : MonoBehaviour, IDragHandler,IBeginDragHandler,IEndDragHandler {
    public void OnBeginDrag(PointerEventData eventData)
    {

        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        //todo : skrypt przetwarzający eventData.position na worldpos
        //Debug.Log(eventData.position);
        GetComponentInParent<RectTransform>().position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void WindowDeactivate()
    {
        gameObject.SetActive(false);
    }
}
