using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		myrigidbody.velocity = Vector2.up * 4;
    }
}