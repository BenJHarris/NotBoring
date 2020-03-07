using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public UnitDestination target;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        navMeshAgent.destination = target.transform.position;
    }

    private void Update()
    {
        if (navMeshAgent.velocity.x > 0.1f)
        {
            spriteRenderer.flipX = true;
        } else
        {
            spriteRenderer.flipX = false;
        }

        if (navMeshAgent.remainingDistance < target.radius)
        {
            UnitDestination[] dests = FindObjectsOfType<UnitDestination>();
            target = dests[Random.Range(0, dests.Length)];
            navMeshAgent.SetDestination(target.transform.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, target.transform.position);
    }
}
