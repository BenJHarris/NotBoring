using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour
{
    public string currentTask;

    private UnitSpeech unitSpeech;
    private UnitMovement unitMovement;

    public GatherWood job;

    public float interactionRange = 2f;
    public int harvestAmount = 10;

    private void Start()
    {
        unitMovement = GetComponent<UnitMovement>();
        unitSpeech = GetComponent<UnitSpeech>();

        job = new GatherWood(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            unitSpeech.Say("hello");
        }

        if (Input.GetKeyDown("c"))
        {
            unitSpeech.Say("THERE");
        }
    }

    private void FixedUpdate()
    {
        if (job != null)
        {
            job.Run();
        }
    }

    public bool InRangeOf(Vector2 destination)
    {
        return Vector2.Distance(transform.position, destination) < interactionRange;
    }

    public void StopMoving()
    {
        unitMovement.StopMovement();
    }

    public void SetDestination(Vector2 dest)
    {
        unitMovement.SetDestination(dest);
    }

    public void Say(string message)
    {
        unitSpeech.Say(message);
    }

    public Tree FindClosestTree()
    {
        Tree[] trees = FindObjectsOfType<Tree>();

        Tree targetTree = trees[0];

        float shortestDistance = Vector2.Distance(transform.position, targetTree.transform.position);

        foreach (Tree tree in trees)
        {
            if (Vector2.Distance(transform.position, tree.transform.position) < shortestDistance)
            {
                shortestDistance = Vector2.Distance(transform.position, tree.transform.position);
                targetTree = tree;
            }
        }

        return targetTree;
    }



}
