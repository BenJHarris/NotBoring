using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Vector2 target;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        navMeshAgent.destination = target;
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
    }

    public void SetDestination(Vector2 destination)
    {
        target = destination;
        navMeshAgent.destination = destination;
    }

    public void StopMovement()
    {
        navMeshAgent.isStopped = true;
    }

    private void OnDrawGizmosSelected()
    {
        if (target != null)
        {
            Gizmos.DrawLine(transform.position, target);
        }
    }
}
