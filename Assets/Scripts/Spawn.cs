using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject supplyPrefab;
    [SerializeField] Transform spawnPoint;
    // bool hasEntered;
    public int SceneIndex;
    void Awake()
    {
        // hasEntered = false;
        SpawnSupplies();

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.Return)) {
        //     // Debug.Log("Player Spawned");
        //     // SpawnPlayer();
        //     hasEntered = true;
        // }
        
    }
    public void OnTriggerEnter2D(Collider2D other) {
        // if (hasEntered) {
            if (other.CompareTag("Player")) {
                Debug.Log("Entered");
                // hasEntered = false;
                SceneManager.LoadScene(SceneIndex, LoadSceneMode.Single);
            }
        // }
    }  

    // void SpawnText(string message) {
    //     GameObject textInstance = Instantiate(textPrefab, spawnPoint.position, Quaternion.identity);
    //     textInstance.GetComponent<TextMeshPro>().text = message; // For TextMeshPro
    //     Destroy(textInstance, 2f);
    // }    

    void SpawnSupplies() {
        Vector3 offset = new Vector3(5, -2, 1);
        GameObject supplies = Instantiate(supplyPrefab, spawnPoint.position + offset, Quaternion.identity);
    }

    void SpawnPlayer() {
        GameObject player = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
    }
}
