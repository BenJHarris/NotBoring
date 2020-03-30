using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    public GameObject addButtonPrefab;
    private GameObject currentButtonInstance;
    private Sea sea;

    private void Start()
    {
        sea = GetComponent<Sea>();
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Pointer entered");
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
        Debug.Log("Pointer exited");
        if (currentButtonInstance != null)
        {
            Destroy(currentButtonInstance);
            currentButtonInstance = null;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Pointer clicked");
        sea.PurchaseLand();
    }
}
