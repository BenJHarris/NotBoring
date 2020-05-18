using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButtonBelow : MonoBehaviour
{

    public IntVariable woodAmount;
    public int min;
    private Button b;

    // Start is called before the first frame update
    void Start()
    {
        b = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (woodAmount.RuntimeValue < min)
        {
            b.interactable = false;
        } else
        {
            b.interactable = true;
        }
    }
}
