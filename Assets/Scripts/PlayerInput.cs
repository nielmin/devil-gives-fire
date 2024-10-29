using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] DiscreteMovement controls;
    [SerializeField] Player p;

    void Awake()
    {
        
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (p.GetLauncher().GetCurAmmo() > 0) {
                p.Shoot();
                p.GetLauncher().currAmmo--;
            } else {
                Debug.Log("Out of Ammo");
            }
        }
        p.AimGun(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
    void FixedUpdate() {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W) || 
        Input.GetKey(KeyCode.S) || 
        Input.GetKey(KeyCode.A) || 
        Input.GetKey(KeyCode.D)) {

        }
        if (Input.GetKey(KeyCode.W)) {
            movement += Vector3.up;

        }
        if (Input.GetKey(KeyCode.S)) {
            movement += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A)) {
            movement += Vector3.left;            

        }
        if (Input.GetKey(KeyCode.D)) {
            movement += Vector3.right;
   
        }

        controls.Movement(movement);
    }

    public Player GetPlayer() {
        return p;
    }
}
