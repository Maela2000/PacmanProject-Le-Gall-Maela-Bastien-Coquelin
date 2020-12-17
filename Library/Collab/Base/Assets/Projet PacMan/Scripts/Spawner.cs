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


// Start is called before the first frame update
void Start()
    {
       
        if (GameplayManager.GetComponent<GameplayManager>().pacgum == 10)
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
        } 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
