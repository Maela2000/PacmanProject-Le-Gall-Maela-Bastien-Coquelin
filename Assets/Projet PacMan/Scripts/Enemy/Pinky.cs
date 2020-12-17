using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pinky : Enemy
{
    private GameObject target;
    NavMeshAgent agent;
    public override void FollowTarget()
    {
        if (alerted == true)
        {
            target = GameObject.FindGameObjectWithTag("Point");
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Enemyspeed * Time.deltaTime);//The enemy follow the player
            agent.SetDestination(target.transform.position);
            }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point") //the ghost follow the player when the gameobject with tag Point2 enter on the collider's ghost
        {
            alerted = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)//the ghost stop follow the player when the gameobject with tag Point2 exit on the collider's ghost
    {
        if (other.gameObject.tag == "Point")
        {
            alerted = false;
        }
    }
}
