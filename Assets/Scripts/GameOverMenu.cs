using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;

public class GameOverMenu : MonoBehaviour
{
    public Animator imageAnimator;
    public GameObject gameUI;
    public GameObject music;
    public GameObject player;
    GameOverTrigger gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = FindObjectOfType<GameOverTrigger>();
        gameUI.SetActive(false);
        music.SetActive(false);
        Time.timeScale = 0f;
        player.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RestartButton();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            StartMenuButton();
        }
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.Quit();
        }
    }

    public void RestartButton()
    {

       // Invoke("RestartScene", 2);

    }
    public void StartMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartScene()
    {
        imageAnimator.gameObject.SetActive(true);
        imageAnimator.SetTrigger("Start");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOver.RestartScene();

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
