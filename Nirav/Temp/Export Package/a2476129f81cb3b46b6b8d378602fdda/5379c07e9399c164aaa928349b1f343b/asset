using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class cameraMovimentation : MonoBehaviour
{
    public GameObject player = null;
    public float minPositionX = 3.4F;
    public float maxPositionX = 65.5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerx = player.transform.position.x;
        if( playerx >= minPositionX && playerx <= maxPositionX)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        
    }
}
