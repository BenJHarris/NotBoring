using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateTMPFromInt : MonoBehaviour
{
    public IntVariable intVariable;
    public TextMeshProUGUI tm;

    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        tm.SetText(intVariable.RuntimeValue.ToString());
    }
}
