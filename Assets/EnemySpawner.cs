using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public float timeUntilFirstWave = 30.0f;
    public float timeBetweenWaves = 60.0f;
    public int waveMinEnemies = 2;
    public int waveMaxEnemies = 10;

    public GameObject enemyPrefab;

    public float radius = 50;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnRoutine");
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, Random.insideUnitCircle.normalized * radius, Quaternion.identity);
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(timeUntilFirstWave);
        for (int i = 0; i < 3; i++)
        {
            SpawnEnemy();
        }
        while (true) {
            yield return new WaitForSeconds(timeBetweenWaves);
            for (int i = 0; i < Random.Range(waveMinEnemies, waveMaxEnemies); i++)
            {
                SpawnEnemy();
            }
        }
    }


}
