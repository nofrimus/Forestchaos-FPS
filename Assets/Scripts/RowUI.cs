using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class RowUI : MonoBehaviour
{
    public TMP_Text rankText;  // Mengganti nama variabel "rank" agar tidak bentrok dengan reserved keyword
    public TMP_Text nameText;
    public TMP_Text scoreText;

    Player player;

    public void Initialize(Player player)
    {
        this.player = player;

        nameText.text = player.NickName;
        UpdateStats();
    }

    void UpdateStats()
    {
        if (player.CustomProperties.TryGetValue("score", out object score))
        {
            scoreText.text = score.ToString();
        }
        if (player.CustomProperties.TryGetValue("rank", out object rank))
        {
            rankText.text = rank.ToString();
        }
    }

    public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)  // Mengubah menjadi method biasa
    {
        if (targetPlayer == player)
        {
            if (changedProps.ContainsKey("kills") || changedProps.ContainsKey("deaths"))
            {
                UpdateStats();
            }
        }
    }
}
