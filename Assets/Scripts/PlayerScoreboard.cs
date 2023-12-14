using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreboard : MonoBehaviour
{
    private int kills;
    private int deaths;
    private string username;

    public int Kills { get { return kills; } }
    public int Deaths { get { return deaths; } }
    public string Username { get { return username; } }

    public void UpdateKillsAndDeaths(string playerName)
    {
        // Implement your logic to update Kills and Deaths here.
        // For simplicity, let's use random values as placeholders.
        kills = Random.Range(0, 10);
        deaths = Random.Range(0, 10);

        // Update the username with the provided playerName.
        username = playerName;

        // Now you can use the 'username' field wherever you need it.
    }
}
