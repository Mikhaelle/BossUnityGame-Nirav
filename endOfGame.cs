using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endOfGame : MonoBehaviour
{
    public GameObject Player;

    public float initialPlayerPositionX = -6.44F;

    public float initialPlayerPositiony = -2F;
    public float initialCameraPositionX = 3.4F;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("PARABÉNS, você venceu");

        var playerPosition = Player.transform.position;
		Player.transform.position = new Vector3(initialPlayerPositionX, initialPlayerPositiony, playerPosition.z);

		var cameraPosition = Camera.main.transform.position;
		Camera.main.transform.position = new Vector3(initialCameraPositionX, cameraPosition.y, cameraPosition.z);
    }
}
