using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScore : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    int finalScore;

    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("finalScore", 0);
        finalScoreText.text = finalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinalScore()
    {

    }
}
