﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptignorecollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreLayerCollision(9, 10, true);
    }
}