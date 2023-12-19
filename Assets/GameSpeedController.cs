using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedController : MonoBehaviour
{
    public float gameSpeed = 1f;
    public float maxSpeed = 10f;

    private void Update()
    {
        gameSpeed += 0.1f * Time.deltaTime;
        gameSpeed = Mathf.Clamp(gameSpeed, 0, maxSpeed);
    }
}
