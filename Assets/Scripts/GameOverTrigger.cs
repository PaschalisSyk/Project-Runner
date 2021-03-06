using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverMenu.activeInHierarchy && Input.GetKeyDown(KeyCode.Space))
        {
            RestartScene();
        }
    }

    public void RestartScene()
    {        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
            player.SetActive(true);
    }
}
