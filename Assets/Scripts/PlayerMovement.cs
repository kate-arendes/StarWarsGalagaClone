using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float maxSpeed = 70;

    public float rightBoundary = 60;

    public float leftBoundary = -60;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement along X axis

        Vector3 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        if(pos.x > rightBoundary)
        {
            pos.x = rightBoundary;
        }

        if(pos.x < leftBoundary)
        {
            pos.x = leftBoundary;
        }

        transform.position = pos;

        // Restrict player to camera area
        
    }
}
