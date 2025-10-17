using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private List<GameObject> enemies = new List<GameObject>();
    private float spawntimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnEnemy(100);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }

        spawntimer += Time.deltaTime;
        if (spawntimer >= 3f)
        {
            SpawnEnemy(3);
            spawntimer = 0f;
        }
    }

    void SpawnEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            enemies.Add(newEnemy);
        }
    }

    void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }
}
