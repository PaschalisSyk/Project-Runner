using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    float timer = 0;
    bool timerReached = false;
    public void Start()
    {
        StartCoroutine(InputWaiter());
    }

    void Update()
    {
        if (!timerReached)
            timer += Time.deltaTime;

        if (!timerReached && timer > 50)
        {
            timerReached = true;

            NextScene();
        }
    }

    IEnumerator InputWaiter()
    {
        yield return new WaitWhile(() => !Input.anyKey);
        NextScene();
    }
    
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
