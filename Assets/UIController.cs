using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
