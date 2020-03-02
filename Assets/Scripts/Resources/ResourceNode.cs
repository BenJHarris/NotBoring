using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceNode : MonoBehaviour
{

    public int startAmount;
    public int currentAmount;
    public string resourceType;
    public int harvestRange = 1;

    // returns amount harvested
    public int harvest(int amount)
    {
        if (currentAmount >= amount)
        {
            currentAmount -= amount;
        } else
        {
            amount = currentAmount;
            currentAmount = 0;
        }
        return amount;
    }
}
