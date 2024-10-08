using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameManager gameManager;

    public int enemyHealth;
    public float scoreValue;

    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        //Spawn Shark, Jellyfish, or etc
        yield return new WaitForSeconds(2);
    }
}
