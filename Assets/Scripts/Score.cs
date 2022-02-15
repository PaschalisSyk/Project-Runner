using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI gameOverHighScoreText;
    public TextMeshProUGUI timeText;

    StarterAssets.ThirdPersonController _player;
    PauseMenu pause;

    public int score;
    public int highScore;
    int multiplier;
    int finalScore;
    string zeros = "0000";
    // Start is called before the first frame update

    void Start()
    {
        pause = FindObjectOfType<PauseMenu>();

        finalScore = score;
        multiplier = 5;

        _player = FindObjectOfType<StarterAssets.ThirdPersonController>();

        highScore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = "HIGHSCORE: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCount();
        HighScore();
        UpdateSpeed();
        GameOverScores();

        PlayerPrefs.SetInt("finalScore", 0);

        
    }

    private void ScoreCount()
    {
        if (_player.alive && !PauseMenu.GameIsPaused)
        {
 
            score = score + multiplier;
        }
        if (_player.alive && PauseMenu.GameIsPaused)
        {
            return;
        }
        scoreText.text = (zeros) + score.ToString("0");
        if (score > 999)
        {
            zeros = "000";
        }
        if (score > 9999)
        {
            zeros = "00";
        }
        else
        scoreText.text = (zeros) + score.ToString("0");
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
    void GameOverScores()
    {
        distanceText.text = "DISTANCE: " + (Math.Round(_player.transform.position.z)) + " m";
        gameOverScoreText.text = "SCORE:  " + score.ToString();
        gameOverHighScoreText.text = highScoreText.text;
        timeText.text = "TIME: " + Time.time.ToString("00.0") + " s";
    }

}
