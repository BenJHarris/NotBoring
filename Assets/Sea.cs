using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sea : MonoBehaviour
{
    public List<GameObject> landPrefabs;

    public IntVariable goldVariable;
    public IntVariable landPrice;
    public IntVariable landPurchased;

    public GameEvent eightPurchased;

    public void PurchaseLand()
    {
        if (goldVariable.RuntimeValue >= landPrice.RuntimeValue)
        {
            goldVariable.RuntimeValue -= landPrice.RuntimeValue;
            landPrice.RuntimeValue *= 2;

            landPurchased.RuntimeValue++;
            if (landPurchased.RuntimeValue == 8)
            {
                eightPurchased.Raise();
            }

            GameObject pf = landPrefabs[Random.Range(0, landPrefabs.Count)];

            GameObject go = Instantiate(pf, transform.parent.transform);
            go.transform.localPosition = transform.localPosition;
            Destroy(this.gameObject);
        }
    }
}
