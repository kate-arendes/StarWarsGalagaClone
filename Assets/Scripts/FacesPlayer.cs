using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesPlayer : MonoBehaviour
{

    public float rotSpeed = 1f;
    
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            return;

        Vector3 dir = player.position - transform.position;

        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        transform.rotation = Quaternion.Euler(0, 0, zAngle);

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }
}
