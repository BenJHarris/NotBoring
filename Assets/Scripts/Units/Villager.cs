using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour
{
    public string currentTask;

    private UnitSpeech unitSpeech;
    private UnitMovement unitMovement;
    public GameObject harvestIcon;

    public GatherWood job;

    public AudioSource harvestAudio;

    public float interactionRange = 2f;
    public int harvestAmount = 10;

    private void Start()
    {
        unitMovement = GetComponent<UnitMovement>();
        StopMoving();
        unitSpeech = GetComponent<UnitSpeech>();
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

    public void startMoving()
    {
        unitMovement.StartMovement();
    }

    public void SetDestination(Vector2 dest)
    {
        unitMovement.SetDestination(dest);
    }

    public void Say(string message)
    {
        unitSpeech.Say(message);
    }

    public void DisplayHarvestIcon(bool display)
    {
        harvestIcon.gameObject.SetActive(display);
    }

    public Tree FindClosestTree()
    {
        Tree[] trees = FindObjectsOfType<Tree>();

        float shortestDistance = float.MaxValue;

        Tree targetTree = null;

        foreach (Tree tree in trees)
        {
            float distanceToTree = Vector2.Distance(transform.position, tree.transform.position);

            if ( distanceToTree < shortestDistance)
            {
                
                if (tree.currentAmount > 0)
                {
                    shortestDistance = distanceToTree;
                    targetTree = tree;
                }
            }
        }
        return targetTree;
    }



}
