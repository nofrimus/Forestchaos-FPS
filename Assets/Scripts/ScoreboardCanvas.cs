using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreboardCanvas : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    public void SetPlayerName(string playerName)
    {
        if (playerNameText != null)
        {
            playerNameText.text = playerName;
        }
        else
        {
            Debug.LogError("PlayerNameText not assigned in the inspector!");
        }
    }
}

