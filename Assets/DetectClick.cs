using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectClick : MonoBehaviour, IPointerClickHandler
{
    public Selectable selectable;

    public void OnPointerClick(PointerEventData eventData)
    {
        selectable.Select();
    }
}
