using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : EnemyBehaviour
{
    void Start()
    {
        enemyHealth = 5;
        scoreValue = 100f;
    }

    void Update()
    {
        if(enemyHealth <= 0)
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        gameManager.UpdateScore(scoreValue);
        gameManager.UpdateJawsPower(-1);
    }
}
