using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject obj;

    public void Toggle()
    {
        obj.SetActive(!obj.activeInHierarchy);
    }
}
