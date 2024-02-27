using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private GameObject[] _enemy;
    [SerializeField] private float _countdownSpawn;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            int randomEnemyIndex = Random.Range(0, _enemy.Length);
            int randomPointIndex = Random.Range(0, _spawnPoint.Length);
            Instantiate(_enemy[randomEnemyIndex], _spawnPoint[randomPointIndex].position, Quaternion.identity);

            yield return new WaitForSeconds(_countdownSpawn);
        }
    }
}
