using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] SaveManager sm;
    public int SceneIndex;
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            sm.SavePlayerPosition();
            SceneManager.LoadScene(SceneIndex, LoadSceneMode.Single);
        }

    }
}
