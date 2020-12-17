using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float Enemyspeed = 2;
    private int randomSpot;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;//creation of gameobject which will serve as indicators
    public Animator animator;
    public Rigidbody2D rb;
    public float timer;
    public GameObject Player;
    public Vector2 direction = Vector2.up;
    public bool vulnerable = false;
    const string Affraid = "Affraid";
    NavMeshAgent agent;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //Processes Animator component
        rb = GetComponent<Rigidbody2D>();//Processes Rigidbody2D component
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, Enemyspeed * Time.deltaTime);//the player random move between the different gameobjects
                                                                                                                                  //if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
                                                                                                                                  //{
        if (waitTime <= 0) //ghosts stop a short time
        {
            randomSpot = Random.Range(0, moveSpots.Length);
            waitTime = startWaitTime;
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
        //}
        if (!vulnerable) //if ghosts not vulnerable, they use the Followtarget function
        {
            FollowTarget();
        }

        setVulnerable();//call function setVulnerable
    }

    public void setVulnerable() //if ghosts are in scared mod (vulnerable), they change animation
    {
        if (vulnerable)
        {
            animator.SetBool(Affraid, true);
        }
        else//ghosts not change animation with vulnerable animation
        {
            animator.SetBool(Affraid, false);
        }
    }



    public virtual void FollowTarget()//a virtual function, the code of the function is in the child classes
    {

    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (vulnerable)//If the ghost touch boxcollider's player, it's destroy
            {
                GameplayManager.Instance.Score += 50;
                Destroy(gameObject);
            }
            else//If the player touch boxcollider's ghost, it's destroy
            {
                Destroy(collision.gameObject);
                GameplayManager.Instance.ShowGameOver();
            }

        }
    }
}


