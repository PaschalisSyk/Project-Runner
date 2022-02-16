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

    // Start is called before the first frame update
    void Start()
    {
        gameUI.SetActive(false);
        music.SetActive(false);
        Time.timeScale = 0f;

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
    }

    public void RestartButton()
    {
        imageAnimator.gameObject.SetActive(true);
        imageAnimator.SetTrigger("Start");

        Invoke("RestartScene", 2);

    }
    public void StartMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
