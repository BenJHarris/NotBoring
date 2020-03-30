using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{

    private GameObject destination;
    private Vector3 startPosition;
    private float startTime;

    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        startPosition = transform.position;
        Land[] allLand = FindObjectsOfType<Land>();
        destination = allLand[Random.Range(0, allLand.Length)].gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(startPosition, destination.transform.position, (Time.time - startTime) * 0.05f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Land")
        {
            for (int i = 0; i < 2; i++)
            {
                Instantiate(enemyPrefab, col.ClosestPoint(transform.position), Quaternion.identity);
            }
            Destroy(gameObject);
        }
            
    }
}
