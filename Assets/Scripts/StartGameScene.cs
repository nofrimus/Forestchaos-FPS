using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartGameScene : MonoBehaviour
{
    public InputField playerNameInputField;

    void Start()
    {
        if (PlayerPrefs.HasKey("playername"))
        {
            string playerName = PlayerPrefs.GetString("playername");
            playerNameInputField.text = playerName;

            // Find the ScoreboardCanvas in the scene
            ScoreboardCanvas scoreboardCanvas = FindObjectOfType<ScoreboardCanvas>();
            if (scoreboardCanvas != null)
            {
                // Set the player name in the ScoreboardCanvas
                scoreboardCanvas.SetPlayerName(playerName);
            }
            else
            {
                Debug.LogError("ScoreboardCanvas not found in the scene!");
            }
        }
    }

    public void SetPlayerName()
    {
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("playername", playerName);

        // Find the ScoreboardCanvas in the scene
        ScoreboardCanvas scoreboardCanvas = FindObjectOfType<ScoreboardCanvas>();
        if (scoreboardCanvas != null)
        {
            // Set the player name in the ScoreboardCanvas
            scoreboardCanvas.SetPlayerName(playerName);
        }
        else
        {
            Debug.LogError("ScoreboardCanvas not found in the scene!");
        }
    }

    // ... (other methods)
}
