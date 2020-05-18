using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateTime : MonoBehaviour
{
    public FloatVariable floatVariable;
    public TextMeshProUGUI tm;

    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {

        Debug.Log(floatVariable.RuntimeValue);
        float val = floatVariable.RuntimeValue;
        if (val < 20) {
            tm.SetText("Morning");
        } else if (val < 50)
        {
            tm.SetText("Afternoon");
        } else
        {
            tm.SetText("Evening");
        }
    }
}
