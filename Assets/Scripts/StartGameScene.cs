using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Import the UI namespace
using TMPro;

public class StartGameScene : MonoBehaviour
{
    public InputField playerNameInputField;  // Change the type to Text

    void Start()
    {
        // Check if the player name parameter exists
        if (PlayerPrefs.HasKey("playername"))
        {
            // Retrieve the player name from PlayerPrefs
            string playerName = PlayerPrefs.GetString("playername");

            // Set the player name in your UI or do any other necessary operations
            playerNameInputField.text = playerName;
        }
        else
        {
            // Handle the case where the player name parameter is not present
            Debug.LogError("Player name parameter not found!");
        }
    }

    // ... (other methods)
}
