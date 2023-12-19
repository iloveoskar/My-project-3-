using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int score;
    public UIController uIController;

    public void AddToScore()
    {
        score++;
        uIController.UpdateScoreText(score);
    }

    public void SetScore(int score)
    {
        this.score = score;
        uIController.UpdateScoreText(score);
    }
}
