using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    // Start is called before the first frame update

    //11.49 x , -2.25 y, 
    //16.73 x, -2.27 y
    public float speed = 3F;
    public Vector3 finalPosition;

    public Vector3 initialPosition;

    float direction = 1F;
    void Start()
    {
        initialPosition.x = 11.49F;
        initialPosition.y = -2.25F;
        transform.position = new Vector3(initialPosition.x, initialPosition.y, transform.position.z);
        finalPosition.x = 16.73F;
        finalPosition.y = -2.27F;
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
