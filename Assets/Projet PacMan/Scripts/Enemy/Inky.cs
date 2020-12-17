using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inky : Enemy
{
    private GameObject target;
   
    public override void FollowTarget()
    {
        if (alerted == true)
        {
            target = GameObject.FindGameObjectWithTag("Point2");
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Enemyspeed * Time.deltaTime);//The ghost follow the gameobject attach with player
            //agent.SetDestination(target.transform.position);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point2") //the ghost follow the player when the gameobject with tag Point2 enter on the collider's ghost
        {
            alerted = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)//the ghost stop follow the player when the gameobject with tag Point2 exit on the collider's ghost
    {
        if (other.gameObject.tag == "Point2")
        {
            alerted = false;
        }
    }
}
