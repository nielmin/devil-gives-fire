using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{    
    [SerializeField] Launcher wand;

    public bool isHit = false;
    public bool playerDead = false;
    public float speed = 5.0f;
    
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Monster")) {
            isHit = true;
            playerDead = true;
            Destroy(this.gameObject, 3f);


        }
        if (other.CompareTag("Supplies")) {
            Debug.Log("Player picked up a potion");
            wand.RefillCurAmmo();
            Destroy(other.gameObject);
        }
    }

    public bool PlayerHasBeenHit() {
        return isHit;
    }

    public bool PlayerDead() {
        return playerDead;
    }
}
