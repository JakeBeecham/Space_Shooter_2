using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int maxAllowed = 10;
    public float spawnTime = 2;

    float elapsedTime = 0;
    int currentSpawnCount = 0;

    [HideInInspector]
    public GameManager manager;

	void Start ()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
	}
	
	void Update ()
    {
		if(currentSpawnCount < maxAllowed)
        {
            elapsedTime += Time.deltaTime;

            if(elapsedTime >= spawnTime)
            {
                SpawnEnemy();
                elapsedTime = 0;
            }
        }
	}

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

        EnemyData data = enemy.GetComponent<EnemyData>();
        data.source = this;

        currentSpawnCount++;
    }

    public void OnEnemyDestroyed()
    {
        currentSpawnCount--;
    }
}