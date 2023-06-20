using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelfDestruct : MonoBehaviour
{
    public float timer = 3f;
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

        if (player == null)
            timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
