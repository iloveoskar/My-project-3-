using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public ScoreTracker scoreTracker;
    public GameObject gameOverPanel;
    public Transform obstacleSpawnerTransform;
    public GameSpeedController speedController;

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void ResetGame()
    {
        foreach (Transform obstacle in obstacleSpawnerTransform)
        {
            Destroy(obstacle.gameObject);
        }
        scoreTracker.SetScore(0);
        gameOverPanel.SetActive(false);
        speedController.gameSpeed = 1;
        Time.timeScale = 1;
    }
}
