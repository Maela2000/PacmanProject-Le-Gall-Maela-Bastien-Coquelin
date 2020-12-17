using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blinky : Enemy
{
    private GameObject target;
    NavMeshAgent agent;
    

    public override void FollowTarget()
    {
        if (alerted == true)
            {
                target = GameObject.FindGameObjectWithTag("Player"); 
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Enemyspeed * Time.deltaTime);//The enemy follow the player
                agent.SetDestination(target.transform.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //the enemy follow the player when the player enter on the collider's enemy
        {
            alerted = true;        
        }
    }
    private void OnTriggerExit2D(Collider2D other)//the enemy stop follow the player when the player exit on the collider's enemy
    {
        if (other.gameObject.tag == "Player")
        {
            alerted = false;
        }
    }

}
