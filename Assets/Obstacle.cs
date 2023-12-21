using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float baseSpeed = 5f;
    public ScoreTracker scoreTracker;
    public Transform playerTransform;
    public bool addedToScore = false;
    public GameSpeedController speedController;

    public void Initialize(ScoreTracker scoreTracker, Transform playerTransform, GameSpeedController speedController)
    {
        this.scoreTracker = scoreTracker;
        this.playerTransform = playerTransform;
        this.speedController = speedController;
    }

    void Update()
    {
        transform.Translate(Vector3.left * baseSpeed * speedController.gameSpeed * Time.deltaTime);

        if (playerTransform.position.x > transform.position.x && !addedToScore)
        {
            scoreTracker.AddToScore();
            addedToScore = true;
        }

        if (playerTransform.position.x - 10 > transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}