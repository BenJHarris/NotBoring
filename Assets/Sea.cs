using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sea : MonoBehaviour
{
    public GameObject landPrefab;

    public void PurchaseLand()
    {
        GameObject go = Instantiate(landPrefab, transform.parent.transform);
        go.transform.localPosition = transform.localPosition;
        Destroy(this.gameObject);
    }
}
