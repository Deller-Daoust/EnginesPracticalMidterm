using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameManager gameInstance;

    float playerScore;

    public float jawsPower;

    void Awake()
    {
        if(gameInstance == null)
        {
            gameInstance = this;
        }
    }

    public void UpdateScore(float scoreValue)
    {
        playerScore += scoreValue;
    }

    public void UpdateJawsPower(float num)
    {
        jawsPower += num;
    }
}
