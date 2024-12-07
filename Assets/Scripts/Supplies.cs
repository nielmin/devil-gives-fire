using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supplies : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    Player p;
    void Start()
    {
        // Debug.Log("Hello");
        p = playerPrefab.GetComponent<Player>();
        Debug.Log(p);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // p.GetLauncher().RefillCurAmmo();
            // Debug.Log(p.GetLauncher().GetCurAmmo());
            // Destroy(gameObject);
        }
    }  
}


