using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(20.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x - speed;
        if (newX < -1)
        {
            newX = 20.0f;
        }
        transform.position = new Vector3(newX, 1.0f, 0.0f);
        
    }
}
