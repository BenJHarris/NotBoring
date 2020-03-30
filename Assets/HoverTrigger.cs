using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    public GameObject addButtonPrefab;
    public GameObject landPrefab;
    private GameObject currentButtonInstance;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (currentButtonInstance != null)
        {
            Destroy(currentButtonInstance);
            currentButtonInstance = null;
        }
        currentButtonInstance = Instantiate(addButtonPrefab, transform);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (currentButtonInstance != null)
        {
            Destroy(currentButtonInstance);
            currentButtonInstance = null;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject go = Instantiate(landPrefab, transform.parent.transform);
        go.transform.localPosition = transform.localPosition;
        Destroy(this.gameObject);
    }
}
