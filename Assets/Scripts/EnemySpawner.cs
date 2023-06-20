using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    float spawnDistance = 20f;

    public float enemyRate = 5;
    
    float nextEnemy = 1;

    Transform player;

 
    // Update is called once per frame
    void Update()
    {

        if (player == null)
        {
            GameObject go = GameObject.Find("xwing");

            if (go != null)
            {
                player = go.transform;
            }
        }

        nextEnemy -= Time.deltaTime;

        if(nextEnemy <=0 && player != null)
        {
            nextEnemy = enemyRate;

            if (player != null)
            {
                enemyRate *= 0.99f;
            }

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;

            offset = offset.normalized * spawnDistance;

            
            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }

        if (player == null)
        {
            enemyRate = 8;
        }

    }
}
