using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByCollision : MonoBehaviour
{

    public int health = 1;

    // Start is called before the first frame update
    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        health--;

    }

    void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
}
