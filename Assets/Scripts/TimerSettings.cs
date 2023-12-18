using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerSettings : MonoBehaviour
{
    public TMP_Text TextTimer;
    public float Waktu = 600;
    public bool GameAktif = true;

    float s;

    private void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }

        if (GameAktif && Waktu <= 0)
        {
            Debug.Log("Game Over");
            GameAktif = false;
            PlayerPrefs.SetInt("UserUI", 1);
            GoBackToSceneBackends(); // Call the function to go back to "Scene Backends"
        }

        SetText();
    }

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    void GoBackToSceneBackends()
    {
        SceneManager.LoadScene("Backends");
        ActivateUserUI();
    }

    void ActivateUserUI()
    {
        // Find the UserUI object in the scene
        GameObject userUI = GameObject.Find("UserUI");

        // Check if the object is found
        if (userUI != null)
        {
            // Check if the object is inactive before activating it
            if (!userUI.activeSelf)
            {
                userUI.SetActive(true);
            }
            else
            {
                Debug.LogWarning("UserUI is already active in the scene.");
            }
        }

        // Assuming "MenuUI" is another object in the scene that you want to deactivate
        GameObject menuUI = GameObject.Find("MenuUI");

        // Check if the object is found
        if (menuUI != null)
        {
            // Check if the object is active before deactivating it
            if (menuUI.activeSelf)
            {
                menuUI.SetActive(false);
            }
            else
            {
                Debug.LogWarning("MenuUI is already inactive in the scene.");
            }
        }
    }
}
