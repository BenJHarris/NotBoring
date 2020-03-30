using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickBackground : MonoBehaviour, IPointerClickHandler
{
    public GameEvent deselectAll;

    public void OnPointerClick(PointerEventData eventData)
    {
        deselectAll.Raise();
    }
}
