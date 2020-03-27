using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPrefabOnHover : MonoBehaviour
{

    public GameObject prefab;

    public GameObject currentInstance;

    private bool show = false;

    public void Show()
    {
        show = true;
    }


    private void Update()
    {
        
        if (show && currentInstance == null)
        {
            currentInstance = Instantiate(prefab, transform);
        } else if (!show && currentInstance != null)
        {
            Destroy(currentInstance);
            currentInstance = null;
        } else
        {
            show = false;
        }
    }
}
