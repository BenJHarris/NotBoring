using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBuildings : MonoBehaviour
{

    public GameObject prefab;

    public void ButtonClicked(int buttonNo)
    {
        Instantiate(prefab);
    }
}
