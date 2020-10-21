using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2mov : MonoBehaviour
{
    public float speed = 3F;
    public Vector3 finalPosition;

    public Vector3 initialPosition;

    float direction = 1F;
    void Start()
    {
        transform.position = new Vector3(initialPosition.x, initialPosition.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction; 

        if(Vector3.Distance(transform.position, finalPosition) < 0.1F ){

            direction = -1F; 
        }

        if(Vector3.Distance(transform.position, initialPosition) < 0.1F ){
            direction = 1F; 
        }
        
    }
}
