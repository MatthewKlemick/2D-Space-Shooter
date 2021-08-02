using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawnscript : MonoBehaviour
{
    float time;

    public float spawntime = 0.2f;

    public GameObject enemy;

    void Update()
    {
        if (time > 0) time -=Time.deltaTime;

        if (time <= 0)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-10 , 10),6);
            Instantiate(enemy, spawnPos, Quaternion.identity);
            time = spawntime;  
        } 
    }
}
