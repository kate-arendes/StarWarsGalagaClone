using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject playerInstance;
    public float respawnTimer;
    public int numLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        numLives--;
        respawnTimer = 5;
        playerInstance = Instantiate(playerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "xwing";
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInstance == null)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                SpawnPlayer();

            }
        }
    }
}
