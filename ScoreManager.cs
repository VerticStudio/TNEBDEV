using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int highScore;

    public Text highScoreText;

    void Awake()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("highscore", 0);

        highScoreText.text = "High Score: " + highScore;
    }
    void Update()
    {
        highScoreText.text = "High Score: " + highScore;
        if (score > highScore)
        {
            highScoreText.text = "High Score: " + score;
        }
    }
}