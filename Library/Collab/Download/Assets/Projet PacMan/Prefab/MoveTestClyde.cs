﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTestClyde : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     /*if(transform.parent.Translate(Vector2.up * speed * Time.deltaTime))
        {
            transform.parent.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (transform.parent.Translate(Vector2.left * speed * Time.deltaTime))
        {
            transform.parent.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else if (transform.parent.Translate(Vector2.down * speed * Time.deltaTime))
        {
            transform.parent.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (transform.parent.Translate(Vector2.right * speed * Time.deltaTime))
        {
            transform.parent.Translate(Vector2.up * speed * Time.deltaTime);
        }*/
    }

    void  OnTriggerEnter2D(Collider2D other)
    {
       
        
    }
}
