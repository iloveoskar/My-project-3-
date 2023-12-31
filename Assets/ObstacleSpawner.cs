using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Obstacle[] obstaclePrefabs;
    public Transform spawnPoint;
    public float spawnRate = 2f;
    public float maxSpeed = 10f;
    private float nextSpawnTime = 0f;
    public ScoreTracker scoreTracker;
    public Transform playerTransform;
    public GameSpeedController speedController;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Obstacle selectedObstacle = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
            Instantiate(selectedObstacle, spawnPoint.position + selectedObstacle.transform.position, Quaternion.identity, transform).Initialize(scoreTracker, playerTransform, speedController);
            nextSpawnTime = Time.time + 5f / (speedController.gameSpeed * Random.Range(0.8f, 1.2f));
        }   
    }
}