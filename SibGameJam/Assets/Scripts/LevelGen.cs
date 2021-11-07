using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGen : MonoBehaviour
{
    private const float DistanceToSpawnLevelParts = 400f;
    
    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Transform Obstacle_1;
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject environment;

    [SerializeField] private Transform[] Obstacles;

    private Vector3 lastEndPosition;

    private Vector3 lastObstacleEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_1.Find("SpawnPos").position;
        lastObstacleEndPosition = Obstacle_1.Find("ObstacleEnd").position;
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, lastEndPosition) < DistanceToSpawnLevelParts)
        {
            SpawnLevelPart();
            SpawnObstacle();
        }
    }

    private void SpawnLevelPart()
    {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("SpawnPos").position;
    }

    private void SpawnObstacle()
    {
        Transform lastObstaclePartTransform = SpawnObstacle(lastObstacleEndPosition);
        lastObstacleEndPosition = lastObstaclePartTransform.Find("ObstacleEnd").position;
    }
    
    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }

    private Transform SpawnObstacle(Vector3 spawnPosition)
    {
        Transform obstaclePartTransform = Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], spawnPosition, Quaternion.identity);
        return obstaclePartTransform;
    }
}
