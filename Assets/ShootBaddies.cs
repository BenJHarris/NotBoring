using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBaddies : MonoBehaviour
{

    public float observeRange = 10f;
    public GameObject closestEnemy;
    public float shootCooldown;
    public float lastShot;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        closestEnemy = FindClosestEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (closestEnemy != null && Time.time - lastShot > shootCooldown)
        {
            Vector3 diff = closestEnemy.transform.position - transform.position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < observeRange * observeRange)
            {
                Vector2 direction = (new Vector2(closestEnemy.transform.position.x, closestEnemy.transform.position.y) - new Vector2(transform.position.x, transform.position.y)).normalized;
                float rotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0f, 0f, rotation - 90));
                lastShot = Time.time;
            }

        }
    }

    private void FixedUpdate()
    {
        closestEnemy = FindClosestEnemy();
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
