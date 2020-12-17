using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
public GameObject Blinky;
    public GameObject Pinky;
    public GameObject Inky;
    public GameObject Clyde;
    public GameObject GameplayManager;
    public int blinkycount;
    public int pinkycount;
    public int inkycount;
    public int clydecount;


// Start is called before the first frame update
void Start()
    {
       
        /*if (GameplayManager.GetComponent<GameplayManager>().pacgum == 10)
        {
            Instantiate(Blinky, transform.position, transform.rotation);
        }
        if (GameplayManager.GetComponent<GameplayManager>().pacgum == 20)
        {
            Instantiate(Pinky, transform.position, transform.rotation);
        }
        if (GameplayManager.GetComponent<GameplayManager>().pacgum == 50)
        {
            Instantiate(Inky, transform.position, transform.rotation);
        }
        if (GameplayManager.GetComponent<GameplayManager>().pacgum == 60)
        {
            Instantiate(Clyde, transform.position, transform.rotation);
        } */
        InvokeRepeating("SpawnEnnemy", 1.0f, 6f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnEnnemy()
    {
        if (blinkycount < 1) //instantiate a ennemy when the count below 3 and add one at count
        {
            Instantiate(Blinky, transform.position, transform.rotation);
            blinkycount += 1;
        }

        if (pinkycount < 1) //instantiate a ennemy when the count below 3 and add one at count
        {
            Instantiate(Pinky, transform.position, transform.rotation);
            pinkycount += 1;
        }

        if (inkycount < 1) //instantiate a ennemy when the count below 3 and add one at count
        {
            Instantiate(Inky, transform.position, transform.rotation);
            inkycount += 1;
        }

        if (clydecount < 1) //instantiate a ennemy when the count below 3 and add one at count
        {
            Instantiate(Clyde, transform.position, transform.rotation);
            clydecount += 1;
        }

    }
}
