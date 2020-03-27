using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceNode : MonoBehaviour
{

    public int startAmount;
    public int currentAmount;

    private Animator animator;

    protected virtual void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("currentAmount", currentAmount);
    }

    // returns amount harvested
    public int Harvest(int amount)
    {
        if (currentAmount >= amount)
        {
            currentAmount -= amount;
        } else
        {
            amount = currentAmount;
            currentAmount = 0;
        }

        animator.SetInteger("currentAmount", currentAmount);
        return amount;
    }


}
