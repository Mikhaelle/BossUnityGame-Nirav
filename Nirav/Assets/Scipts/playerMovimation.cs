using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovimation : MonoBehaviour
{

    // velocidade para o player andar - pode ser setada no unity
    public float maxSpeed = 5;

    public float jumpSpeed = 3;
    // Start is called before the first frame update+

    public int maxJumps = 2; 
    
    int currentJumps = 0;

    Rigidbody2D rigidBody;

    public float initialPlayerPositionX = -6.44F;
    public float initialPlayerPositiony = -2F;
    public float initialCameraPositionX = 3.4F;

    public float hp = 100F;

    public Text hpText;
    void Start()
    {
        hpText.text = "HP: " + hp;
    }

    void Awake()
    {
        //pegando o corpo do personagem
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // pegando setas para movimentação horizontal
        var x = Input.GetAxis("Horizontal");

        // velocidade no eixo y continua constante. Vector2 porque estamos trabalhando com
        //vetores2d(x,y)
        rigidBody.velocity = new Vector2(x * maxSpeed, rigidBody.velocity.y);


        if(Input.GetButtonDown("Jump") && currentJumps < maxJumps) //quer pular
        {
            currentJumps += 1;
            rigidBody.velocity = new Vector2(rigidBody.velocity.x , jumpSpeed);
        }

         if (hp <= 0){
            var playerPosition = transform.position;
		    transform.position = new Vector3(initialPlayerPositionX, initialPlayerPositiony, playerPosition.z);

		    var cameraPosition = Camera.main.transform.position;
		    Camera.main.transform.position = new Vector3(initialCameraPositionX, cameraPosition.y, cameraPosition.z);

            hp = 100F;
            hpText.text = "HP: " + hp;
        } 
          

    }

    //colisão no pulo
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.contacts[0].normal == Vector2.up){
        Debug.Log("OnCollisionEnter2D");
            currentJumps = 0;
        }

        if(other.gameObject.name == "Enemy1"){
            hp += -50;
            hpText.text = "HP: " + hp;

        
        }

        if(other.gameObject.name == "Ball1" || other.gameObject.name == "Ball2"){
            hp += -25;
            hpText.text = "HP: " + hp;
        }

        if(other.gameObject.name == "FallEnemy" && other.contacts[0].normal == Vector2.down){
            hp += -100;
            hpText.text = "HP: " + hp;
        }
    }
}
