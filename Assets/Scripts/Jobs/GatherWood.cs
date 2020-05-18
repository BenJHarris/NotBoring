using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherWood: MonoBehaviour
{
    private Villager villager;
    private Tree currentTarget;
    private State currentState = State.MoveToResource;

    public IntVariable woodVar;

    private float harvestCooldown = 0;

    enum State
    {
        MoveToResource,
        Gathering,
        MoveToDropOff
    }
    private void Start()
    {
        villager = GetComponent<Villager>();
    }
    public void Run()
    {
        if (currentTarget == null)
        {
            villager.DisplayHarvestIcon(false);
            currentTarget = villager.FindClosestTree();
            if (currentTarget != null)
            {
                villager.SetDestination(currentTarget.transform.position);
                currentState = State.MoveToResource;
            }
        }

        if (currentTarget != null)
        {
            switch (currentState)
            {
                case State.MoveToResource:
                    villager.DisplayHarvestIcon(false);
                    villager.Say("Moving to resource");
                    villager.startMoving();
                    if (villager.InRangeOf(currentTarget.transform.position))
                    {
                        villager.StopMoving();
                        villager.Say("Resource reached");
                        currentState = State.Gathering;
                    }
                    break;
                case State.Gathering:
                    villager.DisplayHarvestIcon(true);
                    harvestCooldown -= Time.deltaTime;
                    if (harvestCooldown <= 0)
                    {
                        int harvestAmount = currentTarget.Harvest(villager.harvestAmount);
                        if ( harvestAmount > 0)
                        {
                            villager.harvestAudio.Play();
                            woodVar.RuntimeValue += harvestAmount;
                            if (harvestAmount == villager.harvestAmount)
                            {
                                harvestCooldown = 3;
                            } else
                            {
                                currentTarget = null;
                            }
                        }
                        else
                        {
                            currentTarget = null;
                        }
                    }

                    break;

            }
        }
    }
}
