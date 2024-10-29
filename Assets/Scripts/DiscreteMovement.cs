using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    [SerializeField] Player p;

    Rigidbody2D rb;

    void Awake() {
        rb = p.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Movement(Vector3 movement) {
        rb.velocity = movement * p.speed;
    }

    public Player GetPlayer() {
        return p;
    } 
}
