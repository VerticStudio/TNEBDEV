using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Scor : MonoBehaviour {

    public static int Score = 0;
    private int Last_Score = Score;
    Text Text1;

    private void Start()
    {
        Score = 0;
        Text1 = GetComponent<Text> ();
    }

    void Update()
    {
        if(Last_Score != Score)
        {
            
            Last_Score = Score;
        }
        Text1.text = "Score: " + Score;

        if (Score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", Score);
            PlayerPrefs.Save();
        }
    }

    public void Plus1000()
    {
        Score = Score + 1000;
    }
    public void Plus100()
    {
        Score = Score + 100;
    }
}