using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPoint;
    public float spawnRate = 2f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }
}