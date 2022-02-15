using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public AudioSource music;
    StarterAssets.StarterAssetsInputs input;
    public StarterAssets.ThirdPersonController player;

    public GameObject pauseMenuUI;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape) && player.alive)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        music.pitch = 1f;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        music.pitch *= 0.5f;
    }
}
