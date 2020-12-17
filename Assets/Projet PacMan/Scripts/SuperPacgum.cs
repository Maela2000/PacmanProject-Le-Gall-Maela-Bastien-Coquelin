using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPacgum : MonoBehaviour
{
    public List<GameObject> ghosts;
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
                Destroy(gameObject);//If the player touch superpacgum, the superpacgum is destroy and ghosts change mode with scared mod
                foreach (GameObject ghost in ghosts)
                {
                    ghost.GetComponent<Enemy>().vulnerable = true;
                }
                GameplayManager.Instance.Score += 50;
        }
    }
}

