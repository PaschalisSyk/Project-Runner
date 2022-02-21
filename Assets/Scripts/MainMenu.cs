using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator imageAnim;

    public void PlayGame()
    {
        Invoke("NextScene", 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Fadeout()
    {
        imageAnim.gameObject.SetActive(true);
        imageAnim.SetTrigger("Start");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
