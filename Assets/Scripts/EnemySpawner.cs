using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    private float enemyInterval = 5.0f;

    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }
    private IEnumerator spawnEnemy(float interval, GameObject other)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(other, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, other));
    }
}

