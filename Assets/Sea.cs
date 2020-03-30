using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sea : MonoBehaviour
{
    public GameObject landPrefab;

    public IntVariable goldVariable;
    public IntVariable landPrice;

    public void PurchaseLand()
    {
        if (goldVariable.RuntimeValue >= landPrice.RuntimeValue)
        {
            goldVariable.RuntimeValue -= landPrice.RuntimeValue;
            landPrice.RuntimeValue *= 2;

            GameObject go = Instantiate(landPrefab, transform.parent.transform);
            go.transform.localPosition = transform.localPosition;
            Destroy(this.gameObject);
        }
    }
}
