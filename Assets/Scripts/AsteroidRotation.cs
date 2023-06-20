using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{

    public float rotSpeed = 360f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotAmount = rotSpeed * Time.deltaTime;

        float curRot = transform.localRotation.eulerAngles.z;

        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount)); ;
    }
}
