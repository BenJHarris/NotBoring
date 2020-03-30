using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetLandPrice : MonoBehaviour
{

    public TextMeshPro tmp;
    public IntVariable landPrice;

    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        tmp.text = landPrice.RuntimeValue.ToString() + " Gold";
    }
}
