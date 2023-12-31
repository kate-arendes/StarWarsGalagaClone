﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{ 
    public Vector3 bulletOffset = new Vector3(0, 0f, 0);

    public GameObject bulletPrefab;
    
    public float fireDelay = 0.15f;
    public float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetButtonDown("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }

    }
}
