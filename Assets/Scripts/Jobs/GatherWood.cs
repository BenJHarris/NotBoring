using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherWood
{
    private Villager villager;
    private Tree currentTarget;
    private State currentState = State.MoveToResource;

    enum State
    {
        MoveToResource,
        Gathering,
        MoveToDropOff
    }

    public GatherWood(Villager v)
    {
        villager = v;
    }

    public void Run()
    {
        if (currentTarget == null)
        {
            currentTarget = villager.FindClosestTree();
            villager.SetDestination(currentTarget.transform.position);
        }

        switch(currentState)
        {
            case State.MoveToResource:
                villager.Say("Moving to resource");
                if (villager.InRangeOf(currentTarget.transform.position))
                {
                    villager.StopMoving();
                    villager.Say("Resource reached");
                    currentState = State.Gathering;
                }
                break;
            case State.Gathering:
                currentTarget.Harvest(villager.harvestAmount);
                break;
        }
    }
}
