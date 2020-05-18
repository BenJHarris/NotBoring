using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubAmountOnSpawn : MonoBehaviour
{
    public IntVariable woodCount;
    public int amount;
    
    // Start is called before the first frame update
    void Start()
    {
        woodCount.RuntimeValue -= amount;
    }

}
