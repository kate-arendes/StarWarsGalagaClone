using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);

    public GameObject bulletPrefab;

    public float fireDelay = 0.15f;
    float cooldownTimer = 0;

    Transform player;

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            GameObject go = GameObject.Find("xwing");

            if(go != null)
            {
                player = go.transform;
            }
        }

        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 1800)
        {
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }
    }
}
