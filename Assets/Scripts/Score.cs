using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    StarterAssets.ThirdPersonController _player;

    int score;
    int highScore;
    int multiplier;
    int finalScore;
    // Start is called before the first frame update

    void Start()
    {
        finalScore = score;
        multiplier = 5;

        _player = FindObjectOfType<StarterAssets.ThirdPersonController>();

        highScore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = "HIGHSCORE: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.alive)
        {
            score = score + multiplier;
        }
        scoreText.text = ("000") + score.ToString("0");
        HighScore();
        UpdateSpeed();

        PlayerPrefs.SetInt("finalScore", 0);

        
    }
    public void HighScore()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetInt("highscore", score);
            highScoreText.text = "HIGHSCORE: " + highScore.ToString();
        }
    }
    public void UpdateSpeed()
    {
        if (score > 2000)
        {
            _player.SprintSpeed = _player.MoveSpeed * 1.5f;

            _player.speedMultiplier = 0.01f;
            multiplier = 10; 
        }
        else
        {
            _player.speedMultiplier = 0f;
        }

    }

}
