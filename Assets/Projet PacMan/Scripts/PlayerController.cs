using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Transform teleportTarget1;
    public Transform teleportTarget2;
    public Transform teleportTarget3;
    public Transform teleportTarget4;
    public float speed;//the speed pacman can travel
    const string Death = "Death";
    public bool death = false;
    private Vector2 direction;//the direction pacman is going

    NavMeshAgent agent;

    Rigidbody2D rb2d;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    /*public void PacmanDeath(bool isDeath)
    {
        death = isDeath;
        animator.SetBool(Death, true);
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0) //If the player presses the left arrow, pacman moves to the left even if the player releases the key
        {
            direction = Vector2.left;
        }
        if (Input.GetAxis("Horizontal") > 0)//If the player presses the right arrow, pacman moves to down even if the player releases the key
        {
            direction = Vector2.right;
        }
        if (Input.GetAxis("Vertical") < 0)//If the player presses down arrow, pacman moves to down even if the player releases the key
        {
            direction = Vector2.down;
        }
        if (Input.GetAxis("Vertical") > 0)//If the player presses up arrow, pacman moves to up even if the player releases the key
        {
            direction = Vector2.up;
        }
        rb2d.velocity = direction * speed;
        transform.up = direction;

        if (rb2d.velocity.x == 0)
        {
            transform.position = new Vector2(Mathf.Round(transform.position.x), transform.position.y);
        }
        if (rb2d.velocity.y == 0)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Round(transform.position.y));
        }
    }

    private void OnTriggerEnter2D(Collider2D other) //If the player (pacman) touch a gameobject with a tag Teleport, 
                                                    //it's teleport to a point of the map. The point depending on the teleporter
    {
        if (other.gameObject.tag == "Teleport1")
        {
            transform.position = teleportTarget1.transform.position;
        }
        if (other.gameObject.tag == "Teleport2")
        {
            transform.position = teleportTarget2.transform.position;
        }
        if (other.gameObject.tag == "Teleport3")
        {
            transform.position = teleportTarget3.transform.position;
        }
        if (other.gameObject.tag == "Teleport4")
        {
            transform.position = teleportTarget4.transform.position;
        }

        if (other.gameObject.tag == "Pacgum") //if the player touch pacgum, the pacgum it's destroy 
                                             //and this adds points to the score and increases the number of pacgum eaten by 1 in the GameplayManager class
        {
            GameplayManager.Instance.pacgum += 1;
            GameplayManager.Instance.Score += 25;
            Destroy(other.gameObject);
        }
    }
}


