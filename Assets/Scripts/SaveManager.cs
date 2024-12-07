using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public Vector3 playerStartPosition; // Optionally set a default start position

    void Start()
    {
        LoadPlayerPosition();
    }

    public void SavePlayerPosition()
    {
        // Save player's position as three separate floats
        PlayerPrefs.SetFloat("PlayerPosX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", transform.position.z);

        // Make sure to save it immediately
        PlayerPrefs.Save();
    }

    public void LoadPlayerPosition()
    {
        // If player position data exists in PlayerPrefs, load it
        if (PlayerPrefs.HasKey("PlayerPosX") && PlayerPrefs.HasKey("PlayerPosY") && PlayerPrefs.HasKey("PlayerPosZ"))
        {
            float x = PlayerPrefs.GetFloat("PlayerPosX");
            float y = PlayerPrefs.GetFloat("PlayerPosY");
            float z = PlayerPrefs.GetFloat("PlayerPosZ");

            transform.position = new Vector3(x, y, z);
        }
        else
        {
            // If no saved position, set a default position
            transform.position = playerStartPosition;
        }
    }

    // Example usage: Save position when the game ends or on scene transition
    void OnApplicationQuit()
    {
        SavePlayerPosition();
    }
}
