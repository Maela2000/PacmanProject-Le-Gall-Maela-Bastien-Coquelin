using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSupPacGum : MonoBehaviour
{
    public GameObject SPG;
    public int SPGcount;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnnemy", 1.0f, 6f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnEnnemy()
    {
        if (SPGcount < 1) //instantiate a ennemy when the count below 3 and add one at count
        {
            Instantiate(SPG, transform.position, transform.rotation);
            SPGcount += 1;
        }
    }
}
