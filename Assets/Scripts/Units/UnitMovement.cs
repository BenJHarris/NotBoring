using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Vector2 target;
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    private void Start()
    {
        
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        navMeshAgent.destination = target;
    }

    private void Update()
    {
        animator.SetFloat("Speed", navMeshAgent.velocity.sqrMagnitude / 10);
        if (navMeshAgent.velocity.x > 0.01f)
        {
            spriteRenderer.flipX = true;
        } else if (navMeshAgent.velocity.x < -0.01f)
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

    public void StartMovement()
    {
        navMeshAgent.isStopped = false;
    }

    private void OnDrawGizmosSelected()
    {
        if (target != null)
        {
            Gizmos.DrawLine(transform.position, target);
        }
    }
}
