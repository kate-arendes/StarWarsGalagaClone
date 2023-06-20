using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{

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

        MeshRenderer mr = GetComponent<MeshRenderer>();
        
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        if (player != null)
        {
            offset.y += Time.deltaTime / 4.2f;
        }
        mat.mainTextureOffset = offset;
    }
}
