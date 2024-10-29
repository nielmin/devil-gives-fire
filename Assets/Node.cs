using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Node : MonoBehaviour
{
    public int SceneIndex;
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Entered new level");
            SceneManager.LoadScene(SceneIndex, LoadSceneMode.Single);
            }
        }  
}
