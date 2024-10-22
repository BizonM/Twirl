using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private bool spawnEnemies = false;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector2 spawnPosition;
    [SerializeField] private float spawnRadius;
    [SerializeField] private float spawnInterval;
    [SerializeField] private float minSpawnDistanceFromPlayer;
    [SerializeField] private float nextSpawnTime;

    private void FixedUpdate()
    {
        if(spawnEnemies)
            SpawnEnemyInIntervals();
    }

    void SpawnEnemyInIntervals()
    {
        if (Time.time >= nextSpawnTime)
        {
            GenerateRandomSpawnPosition();
            Instantiate(enemyPrefab, spawnPosition, quaternion.identity);
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
    Vector2 GenerateRandomSpawnPosition()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        float randomDistance = Random.Range(minSpawnDistanceFromPlayer, spawnRadius);
        spawnPosition = (Vector2)playerTransform.position + (randomDirection * randomDistance);
        return spawnPosition;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(playerTransform.position, minSpawnDistanceFromPlayer);

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(playerTransform.position, spawnRadius);
    }
}
